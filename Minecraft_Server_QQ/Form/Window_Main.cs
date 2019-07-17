using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Minecraft_Server_QQ
{
    partial class Window_Main : Form
    {
        private server_save server_save;

        private void safe_opPluginsList(object sender,object e)
        {
            if (sender == null)
                listView_plugins.Items.Clear();
            else
            {
                string[] Arr = (string[])sender;
                ListViewItem item = new ListViewItem(new string[] { Arr[0], Arr[1], Arr[2], Arr[3] });
                listView_plugins.Items.Add(item);
            }
        }//插件列表操作函数，用于多线程下的插件列表增加数据
        private void safe_opModsList(object sender,object e)
        {
            if (sender == null)
                listView_mods.Items.Clear();
            else
            {
                string[] Arr = (string[])sender;
                ListViewItem item = new ListViewItem(new string[] { Arr[0], Arr[1], Arr[2], Arr[3] });
                listView_mods.Items.Add(item);
            }
        }//同上
        private void safe_opButton(object sender,object var) 
        {
            Button button = (Button)sender;
            bool enabled = (bool)var;
            button.Enabled = enabled;
        }//用于多线程下的按钮Enabled属性操作
        private void safe_opToolStripStatusLabel(object sender, object var) 
        {
            ToolStripStatusLabel s = (ToolStripStatusLabel)sender;
            s.Text = "状态: " + (string)var;
        }//同上，用于状态条

        private void th_showInfo() 
        {

        }//显示信息线程，用于显示包括版本信息，开服后的内存信息等，并且负责软件开启后自动更新DNS 

        public Window_Main(server_save server)
        {
            this.server_save = server;
            InitializeComponent();
        }
        //窗口初始化事件
        private void Window_Main_Load(object sender, EventArgs e)
        {
            server_save.Server = new MCServer(server_save.server_local);
            server_save.Server.serverMessage += new MCServer.serverEventHandler(Server_serverMessage);
            server_save.Server.serverRestart += new MCServer.serverEventHandler(Server_serverRestart);
            server_save.Server.serverStop += new MCServer.serverEventHandler(Server_serverStop);
            server_save.Task_list = new MCSTask(server_save.Server,Application.StartupPath);
            server_save.Task_list.ptask += new MCSTask.pTask(Task_ptask);
            server_save.Task_list.InitTask();
            server_save.Task_list.StartTask();
            new Thread(th_showInfo).Start();
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
            button_serverRun.Invoke(new server_save.opEventHandler(safe_opButton),new object[]{button_serverRun,true});
            button_serverStop.Invoke(new server_save.opEventHandler(safe_opButton), new object[]{button_serverStop,false});
            button_serverRest.Invoke(new server_save.opEventHandler(safe_opButton),new object[]{button_serverRest,false});
            if (e != null)
            {
                if (e.exitCode == 0)
                    Server_serverMessage(null, new Event.MCSEvent("[提示]服务器已正常关闭", 0));
                else
                    Server_serverMessage(null, new Event.MCSEvent("[提示]服务器已被强制关闭或崩溃", 0));
            }
        }
        //事件-服务器重启完毕
        void Server_serverRestart(object sender, Event.MCSEvent e)
        {
            button_serverRun.Invoke(new server_save.opEventHandler(safe_opButton), new object[] { button_serverRun ,false});
            button_serverStop.Invoke(new server_save.opEventHandler(safe_opButton), new object[] { button_serverStop, true });
            button_serverRest.Invoke(new server_save.opEventHandler(safe_opButton), new object[] { button_serverRest, true });
        }
        //事件-服务器回显消息通知
        void Server_serverMessage(object sender, Event.MCSEvent e)
        {
            if (textBox_serverInfo.InvokeRequired)
                Invoke(new server_save.serverEventHandler(Server_serverMessage), new object[] { sender, e });
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
            string configFile = Application.StartupPath + @"\config.ini";
            if (!File.Exists(Application.StartupPath + @"\server\Start.jar"))
            {
                MessageBox.Show("服务器核心未找到，请设置为Start.jar");
                return;
            }
            //读取开服所需相关参数并检测，生成启动命令行
            string javaPath = WinAPI.GetPrivateProfileString(configFile, "config", "javaPath", "");
            if (javaPath == "")
            {
                //尝试自动搜索java.exe
                javaPath = other.SeachJava();
                if (javaPath != "")
                    WinAPI.WritePrivateProfileString(configFile,"config","javaPath",javaPath);
            }
            if (!File.Exists(javaPath))
            {
                MessageBox.Show("Java路径无效！请在设置中手动设置Java路径。");
                return;
            }
            //创建eula.txt
            MCconfig config = new MCconfig();
            config.Init(Application.StartupPath+@"\server\eula.txt");
            config.SetString("eula","true");
            config.UnInit(true);
            //端口检测
            config.Init(Application.StartupPath + @"\server\server.properties");
            int Port ;
            try { Port = int.Parse(config.GetString("server-port")); }
            catch { Port = 25565; }
            config.UnInit(false);
            if (!other.PortInUse(Port))
            {
                MessageBox.Show("服务器端口被占用！请关闭占用端口的进程或者重启电脑。");
                return;
            }
            //根据配置文件生成相关参数
            string cmd;
            cmd = WinAPI.GetPrivateProfileString(configFile, "config", "javaParameter","");
            int maxMemory;
            try
            {
                maxMemory = int.Parse(WinAPI.GetPrivateProfileString(configFile, "config", "MaxMemory", "0"));
            }
            catch { maxMemory = 0; }
            string moreline = WinAPI.GetPrivateProfileString(configFile,"config","MoreLine","");
            if (maxMemory != 0)
            {
                cmd = cmd + " -Xmx" + maxMemory.ToString() + "M -jar -Djline.terminal=jline.UnsupportedTerminal";
            } else {
                cmd = cmd + " -jar -Djline.terminal=jline.UnsupportedTerminal";
            }
            //采用相对路径，避免非中文系统下中文目录导致的开服失败。
            cmd = cmd + " \"..\\server\\Start.jar\"";
            if (moreline != "")
                cmd = cmd + " " + moreline;
            string serverType = WinAPI.GetPrivateProfileString(Application.StartupPath + @"\config.ini", "config", "ServerType", "0");
            if (serverType == "2" || serverType == "3")
                cmd = cmd + " nogui";
            if (!server_save.Server.Run(javaPath,cmd))
            {
                MessageBox.Show("进程创建失败！");
                Debug.WriteLine(javaPath);
                return;
            }
            //进程创建成功
            button_serverRun.Invoke(new server_save.opEventHandler(safe_opButton),new object[]{button_serverRun,false});
            button_serverStop.Invoke(new server_save.opEventHandler(safe_opButton),new object[]{button_serverStop,true});
            button_serverRest.Invoke(new server_save.opEventHandler(safe_opButton), new object[]{button_serverRest,true});
        }
        //关闭服务器
        private void button_serverStop_Click(object sender, EventArgs e)
        {
            server_save.Server.Stop();
        }
        //重启服务器
        private void button_serverRest_Click(object sender, EventArgs e)
        {
            if (!server_save.Server.IsRun())
            {
                MessageBox.Show("请先等待服务端运行后再重启");
                return;
            }
            server_save.Server.Restart();
            button_serverRun.Invoke(new server_save.opEventHandler(safe_opButton), new object[] {button_serverRun,false});
            button_serverStop.Invoke(new server_save.opEventHandler(safe_opButton),new object[]{button_serverStop,false});
            button_serverRest.Invoke(new server_save.opEventHandler(safe_opButton),new object[]{button_serverRest,false});
    
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
                server_save.wz = -1;
                foreach (string s in server_save.line)
                {
                    server_save.wz++;
                    if (s == "" || s == null)
                        break;
                }//计算出最后的位置
                server_save.wz++;
                server_save.Server.SendMessage(textBox_sendServer.Text);
                if (server_save.wz == 1)
                {
                    server_save.line[0] = textBox_sendServer.Text;
                }
                else
                {
                    if (server_save.line[server_save.wz - 2] != textBox_sendServer.Text)
                    {
                        //将指令加入line数组
                        if (server_save.wz != server_save.LINEMAX)
                        {
                            server_save.line[server_save.wz - 1] = textBox_sendServer.Text;
                        }
                        else
                        {
                            server_save.line[server_save.wz - 1] = textBox_sendServer.Text;
                            ArrShangYi(server_save.line);
                            server_save.wz--;
                        }
                    }
                    else 
                    {
                        server_save.wz--;
                    }
                }
                textBox_sendServer.Text = "";
            }
            if (e.KeyCode == Keys.Up)
            {
                if (server_save.wz != 0)
                    server_save.wz--;
                textBox_sendServer.Text= server_save.line[server_save.wz];
            }
            if (e.KeyCode == Keys.Down)
            {
                if (server_save.wz < server_save.LINEMAX -1)
                    server_save.wz++;
                textBox_sendServer.Text = server_save.line[server_save.wz];
            }
        }
        private void ArrShangYi(string[] s)
        {
            string[] tmp = new string[server_save.LINEMAX];
            s.CopyTo(tmp, 0);
            for (int i = 0; i < server_save.LINEMAX -1; i++)
            {
                s[i] = tmp[i + 1];
            }
            s[server_save.LINEMAX - 1] = null;
        }
        //程序即将关闭
        private void Window_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server_save.Server.IsProcessRun())
            {
                MessageBox.Show("请先关闭服务器再退出软件！");
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }
        //选项卡被选择
        private void tabControl1_SelectingAsync(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage_serverSet)
            {
                Task.Factory.StartNew(() =>
                {
                    server server = new server();
                    server.ReadMCServerConfig(server_save);
                });
            }
            else if (e.TabPage == tabPage_serverPlugin)
            {
                plugins_mod plugins = new plugins_mod();
                Task.Factory.StartNew(() =>
                {
                    plugin_mod_list list = plugins.ReadPluginsInfo(server_save.server_local);
                    if (list != null)
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
                    }
                });
            }
            else if (e.TabPage == tabPage_serverMod)
            {
                plugins_mod mod = new plugins_mod();
                Task.Factory.StartNew(() =>
                {
                    plugin_mod_list list = mod.ReadPluginsInfo(server_save.server_local);
                    if (list != null)
                    {
                        listView_plugins.Items.Clear();
                        foreach (plugin_mod_save save in list.list)
                        {
                            ListViewItem test = new ListViewItem(save.name);
                            test.SubItems.Add(save.version);
                            test.SubItems.Add(save.auth);
                            test.SubItems.Add(save.file);
                            listView_mods.Items.Add(test);
                        }
                    }
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
            propertyGrid1.SelectedObject = null;
            server server = new server();
            server.ReadMCServerConfig(server_save);
        }
        //保存游戏设置
        private void button_saveServerSet_Click(object sender, EventArgs e)
        {
            server server = new server();
            if (server.SaveMCServerConfig(server_save))
                MessageBox.Show("保存设置成功");
            else
                MessageBox.Show("保存设置失败，请检查服务器设置文件是否被占用。");
        }
        //自动搜索java
        private void button_autoSeach_Click(object sender, EventArgs e)
        {
            string s = other.SeachJava();
            if (s == "")
            {
                MessageBox.Show("程序未能自动搜索到java.exe所在位置，请手动选择。");
                return;
            } else {
                textBox_javaPath.Text = s;
                WinAPI.WritePrivateProfileString(Application.StartupPath+@"\config.ini","config","javaPath",s);
            }
        }
        //手动选择java
        private void button_select_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "java主程序|java.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_javaPath.Text = openFileDialog1.FileName;
                WinAPI.WritePrivateProfileString(Application.StartupPath + @"\config.ini", "config", "javaPath", openFileDialog1.FileName);
            }
        }
        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void GroupBox_41_Enter(object sender, EventArgs e)
        {

        }
        private void ListView_plugins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}