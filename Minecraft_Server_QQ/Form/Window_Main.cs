using Minecraft_Server_QQ.Config;
using Minecraft_Server_QQ.Mc_server;
using Minecraft_Server_QQ.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    partial class Window_Main : Form
    {
        private Config_class server_save;
        private bool plugins_run = false;
        private bool mods_run = false;

        private void safe_opButton(object sender,object var) 
        {
            Button button = (Button)sender;
            bool enabled = (bool)var;
            button.Enabled = enabled;
        }//用于多线程下的按钮Enabled属性操作
        private void th_showInfo() 
        {

        }//显示信息线程，用于显示包括版本信息，开服后的内存信息等，并且负责软件开启后自动更新DNS 
        public Window_Main(Config_class server)
        {
            this.server_save = server;
            InitializeComponent();
        }
        //窗口初始化事件
        private void Window_Main_Load(object sender, EventArgs e)
        {
            if (server_save.Server == null)
            {
                server_save.Server = new MCServer(server_save.server_local);
                server_save.Server.serverMessage += new MCServer.serverEventHandler(Server_serverMessage);
                server_save.Server.serverRestart += new MCServer.serverEventHandler(Server_serverRestart);
                server_save.Server.serverStop += new MCServer.serverEventHandler(Server_serverStop);
                server_save.Task_list = new MCSTask(server_save.Server, Application.StartupPath);
                server_save.Task_list.ptask += new MCSTask.pTask(Task_ptask);
                server_save.Task_list.InitTask();
                server_save.Task_list.StartTask();
                new Thread(th_showInfo).Start();
            }
            Name = server_save.server_name + "监视窗口";
            WinAPI.MEMORYSTATUS1 vBuffer = new WinAPI.MEMORYSTATUS1();//实例化结构  
            vBuffer.dwLength = 64;
            WinAPI.GlobalMemoryStatusEx(ref vBuffer);//给此结构赋值搜索            
            long max_m = vBuffer.ullTotalPhys / 1024 / 1024;
            java_max.Maximum = max_m;
            java_min.Maximum = max_m;

            server_name.Text = server_save.server_name;
            server_local.Text = server_save.server_local;
            server_core.Text = server_save.server_core;
            server_arg.Text = server_save.server_arg;
            java_local.Text = server_save.java_local;
            java_arg.Text = server_save.java_arg;
            java_min.Value = server_save.min_m;
            java_max.Value = server_save.max_m;
            auto_restart.Checked = server_save.auto_restart;
            open_start.Checked = server_save.open_start;
        }
        //事件-计划任务应执行 
        void Task_ptask(int s)
        {
            if (s == 0)
                button_serverStop_Click(null,null); //关闭服务器
            if (s == 1)
                button_serverRun_Click(null,null);//开启服务器
            if (s == 2)
                button_serverRest_Click(null,null);//重启服务器
        }
        //事件-服务器被关闭
        void Server_serverStop(object sender, Event.MCSEvent e)
        {
            button_serverRun.Invoke(new MCServer_API.opEventHandler(safe_opButton),new object[]{button_serverRun,true});
            button_serverStop.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[]{button_serverStop,false});
            button_serverRest.Invoke(new MCServer_API.opEventHandler(safe_opButton),new object[]{button_serverRest,false});
            if (e != null)
            {
                if (e.exitCode == 0)
                    Server_serverMessage(null, new Event.MCSEvent("[提示]服务器已正常关闭", 0));
                else
                    Server_serverMessage(null, new Event.MCSEvent("[提示]服务器已被强制关闭或崩溃", 0));
                logs.Log_write(e.exitCode.ToString());
            }
        }
        //事件-服务器重启完毕
        void Server_serverRestart(object sender, Event.MCSEvent e)
        {
            button_serverRun.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverRun ,false});
            button_serverStop.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverStop, true });
            button_serverRest.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverRest, true });
        }
        //事件-服务器回显消息通知
        void Server_serverMessage(object sender, Event.MCSEvent e)
        {
            if (textBox_serverInfo.InvokeRequired)
                Invoke(new MCServer_API.serverEventHandler(Server_serverMessage), new object[] { sender, e });
            else
            {
                if (textBox_serverInfo.Text.Length >= 30000)
                    textBox_serverInfo.Text = "";
                textBox_serverInfo.Text = textBox_serverInfo.Text + e.cmd + "\r\n";
                textBox_serverInfo.SelectionStart = textBox_serverInfo.Text.Length - 1;
                textBox_serverInfo.ScrollToCaret();
            }
        }
        //开启服务器按钮被点击
        private void button_serverRun_Click(object sender, EventArgs e)
        {
            if (!File.Exists(server_save.server_local + server_save.server_core))
            {
                MessageBox.Show("服务器核心未找到，请设置为Start.jar");
                return;
            }
            //读取开服所需相关参数并检测，生成启动命令行
            string javaPath = server_save.java_local;
            if (string.IsNullOrWhiteSpace(javaPath) || !File.Exists(javaPath))
            {
                MessageBox.Show("JAVA错误，请重新设置");
                return;
            }
            //创建eula.txt
            Config_properties config = new Config_properties();
            if (!File.Exists(server_save.server_local + "eula.txt"))
            {
                if (MessageBox.Show("EULA文件缺失，是否同意MOJANG EULA", "EULA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    config.Init(server_save.server_local + "eula.txt");
                    config.SetString("eula", "true");
                    config.UnInit(true);
                }
                else
                {
                    MessageBox.Show("你需要同意开服协议才能开服。");
                    return;
                }
            }
            if (!File.Exists(server_save.server_local + "server.properties"))
            {
                //端口检测
                config.Init(server_save.server_local + "server.properties");
                int Port = 25565;
                if (!other.PortInUse(Port))
                {
                    MessageBox.Show("服务器端口25565被占用！请关闭占用端口的进程或者重启。");
                    return;
                }
            }
            //根据配置文件生成相关参数
            if (server_save.max_m == 0 || server_save.min_m == 0)
            {
                MessageBox.Show("内存设置错误");
                return;
            }
            string cmd = string.Format("{0} -Xmx{1}M -Xms{2}M -Djline.terminal=jline.UnsupportedTerminal -jar \"{3}\" {4}",
                server_save.java_arg, server_save.max_m.ToString(), server_save.min_m.ToString(),
                server_save.server_local + server_save.server_core, server_save.server_arg);
            //采用相对路径，避免非中文系统下中文目录导致的开服失败。
            if (!server_save.Server.Run(javaPath, cmd))
            {
                MessageBox.Show("进程创建失败！");
                return;
            }
            logs.Log_write("启动服务器：" + cmd);
            //进程创建成功
            button_serverRun.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverRun, false });
            button_serverStop.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverStop, true });
            button_serverRest.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] { button_serverRest, true });
        }
        //关闭服务器
        private void button_serverStop_Click(object sender, EventArgs e)
        {
            server_save.Server.Stop();
        }
        //重启服务器
        private void button_serverRest_Click(object sender, EventArgs e)
        {
            if (server_save.Server.IsRun() == 0)
            {
                MessageBox.Show("请先等待服务端运行后再重启");
                return;
            }
            server_save.Server.Restart();
            button_serverRun.Invoke(new MCServer_API.opEventHandler(safe_opButton), new object[] {button_serverRun,false});
            button_serverStop.Invoke(new MCServer_API.opEventHandler(safe_opButton),new object[]{button_serverStop,false});
            button_serverRest.Invoke(new MCServer_API.opEventHandler(safe_opButton),new object[]{button_serverRest,false});
    
        }
        //强制关闭服务器
        private void button_serverClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要强制关闭服务器么？这样做将会导致服务器地图回档。", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                server_save.Server.Close();
            }
        }
        //输入文本到服务器后台相关
        private void textBox_sendServer_Enter(object sender, EventArgs e)
        {
            if (textBox_sendServer.Text == "(输入内容并回车可以将指令发送给服务端)" && textBox_sendServer.ForeColor == Color.Gray)
            {
                textBox_sendServer.Text = "";
                textBox_sendServer.ForeColor = Color.Black;
            }
        }
        private void textBox_sendServer_Leave(object sender, EventArgs e)
        {
            if (textBox_sendServer.Text == "" && textBox_sendServer.ForeColor == Color.Black)
            {
                textBox_sendServer.Text = "(输入内容并回车可以将指令发送给服务端)";
                textBox_sendServer.ForeColor = Color.Gray;
            }
        }
        private void textBox_sendServer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                server_save.Commder_line_now = -1;
                string now = textBox_sendServer.Text;
                if (string.IsNullOrWhiteSpace(now))
                    return;
                //输入的指令是最后一个
                if (server_save.Commder_line[server_save.Commder_line.Count] == now)
                {
                    //不记录发送
                    server_save.Commder_line_now = server_save.Commder_line.Count;
                    server_save.Server.SendMessage(textBox_sendServer.Text);
                    return;
                }
                else
                {
                    server_save.Commder_line.Add(now);
                    server_save.Commder_line_now = server_save.Commder_line.Count;
                }
            }
            else if (server_save.Commder_line.Count == 0)
                return;
            else if(e.KeyCode == Keys.Up)
            {
                if (server_save.Commder_line_now != 0)
                    server_save.Commder_line_now--;
                else
                    return;
                textBox_sendServer.Text= server_save.Commder_line[server_save.Commder_line_now];
            }
            else if(e.KeyCode == Keys.Down)
            {
                if (server_save.Commder_line_now < server_save.Commder_line.Count)
                    server_save.Commder_line_now++;
                else
                    return;
                textBox_sendServer.Text = server_save.Commder_line[server_save.Commder_line_now];
            }
        }
        //选项卡被选择
        private void tabControl1_SelectingAsync(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage_serverSet)
            {
                server server = new server();
                config.SelectedObject = server.ReadMCServerConfig(server_save);
            }
            else if (e.TabPage == tabPage_serverPlugin && plugins_run == false)
            {
                plugins_run = true;
                plugins_mod plugins = new plugins_mod();
                Task.Factory.StartNew(() =>
                {
                    plugin_mod_list list = plugins.ReadPluginsInfo(server_save.server_local);
                    if (list != null)
                    {
                        Action<int> action = (data) =>
                        {
                            listView_plugins.Items.Clear();
                            foreach (plugin_mod_save save in list.list)
                            {
                                ListViewItem test = new ListViewItem(save.name);
                                test.SubItems.Add(save.version);
                                test.SubItems.Add(save.auth);
                                test.SubItems.Add(save.file);
                                listView_plugins.Items.Add(test);
                            }
                        };
                        Invoke(action, 0);
                    }
                    plugins_run = false;
                });
            }
            else if (e.TabPage == tabPage_serverMod && mods_run == false)
            {
                mods_run = true;
                plugins_mod mod = new plugins_mod();
                Task.Factory.StartNew(() =>
                {
                    plugin_mod_list list = mod.ReadModInfo(server_save.server_local);
                    if (list != null)
                    {
                        Action<int> action = (data) =>
                        {
                            listView_mods.Items.Clear();
                            foreach (plugin_mod_save save in list.list)
                            {
                                ListViewItem test = new ListViewItem(save.name);
                                test.SubItems.Add(save.version);
                                test.SubItems.Add(save.auth);
                                test.SubItems.Add(save.file);
                                listView_mods.Items.Add(test);

                            }
                        };
                        Invoke(action, 0);
                    }
                    mods_run = false;
                });
            }
            else if (e.TabPage == tabPage_serverTask)
            {
                Task.Factory.StartNew(() =>
                {
                    server server = new server();
                    server.ReadTaskInfo(server_save);
                });
            }
        }
        //刷新游戏设置
        private void button_readServerSet_Click(object sender, EventArgs e)
        {
            config.SelectedObject = null;
            server server = new server();
            config.SelectedObject = server.ReadMCServerConfig(server_save);
        }
        //保存游戏设置
        private void button_saveServerSet_Click(object sender, EventArgs e)
        {
            server server = new server();
            if (server.SaveMCServerConfig(server_save, (Propertie_Set)config.SelectedObject))
                MessageBox.Show("保存设置成功");
            else
                MessageBox.Show("保存设置失败，请检查服务器设置文件是否被占用。");
        }
        private void ListView_plugins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(server_name.Text)
                || string.IsNullOrWhiteSpace(server_local.Text)
                || string.IsNullOrWhiteSpace(server_core.Text))
            {
                MessageBox.Show("参数缺少，请检查");
                return;
            }
            string a = server_save.server_name;
            server_save.server_name = server_name.Text;
            server_save.server_local = server_local.Text;
            server_save.server_core = server_core.Text;
            server_save.server_arg = server_arg.Text;
            server_save.java_local = java_local.Text;
            server_save.java_arg = java_arg.Text;
            server_save.min_m = (int)java_min.Value;
            server_save.max_m = (int)java_max.Value;
            server_save.auto_restart = auto_restart.Checked;
            server_save.open_start = open_start.Checked;
            Config_write.write_server(Start.APP_local + Config_file.server, server_save);
            if (Config_file.server_list.ContainsKey(a) == true)
                Config_file.server_list.Remove(a);
            Config_file.server_list.Add(server_save.server_name, server_save);
            Start.updata = true;
        }

        private void Button_server_core_Click(object sender, EventArgs e)
        {
            server_local_core.ShowDialog();
            if (string.IsNullOrWhiteSpace(server_local_core.FileName))
            {
                MessageBox.Show("错误的文件名，请重新选择");
                return;
            }
            server_core.Text = server_local_core.SafeFileName;
            server_local.Text = server_local_core.FileName.Replace(server_local_core.SafeFileName, "");
        }

        private void Button_java_Click(object sender, EventArgs e)
        {
            java_local_chose.ShowDialog();
            if (string.IsNullOrWhiteSpace(java_local_chose.FileName))
            {
                MessageBox.Show("错误的文件名，请重新选择");
                return;
            }
            java_local.Text = java_local_chose.FileName;
        }

        private void Button_java_auto_Click(object sender, EventArgs e)
        {
            string a = other.SeachJava();
            if (string.IsNullOrWhiteSpace(a) == false)
            {
                java_local.Text = a;
            }
            else
            {
                MessageBox.Show("未找到JAVA");
            }
        }

        private void Config_Click(object sender, EventArgs e)
        {

        }
    }
}