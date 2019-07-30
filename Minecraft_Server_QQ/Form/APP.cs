using Minecraft_Server_QQ.Config;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    public partial class APP : Form
    {
        public APP()
        {
            InitializeComponent();
        }
        private void APP_Closing(object sender, FormClosingEventArgs e)
        {
            if (Config_file.server_list.Count != 0)
            {
                Dictionary<string, Config_class>.ValueCollection servers = Config_file.server_list.Values;
                foreach (Config_class server in servers)
                {
                    Task.Factory.StartNew(() =>
                    {
                        if(server.Task_list != null)
                            server.Task_list.StopTask();
                        if (server.Server != null && server.Server.IsProcessRun() == true)
                        {
                            server.Server.Stop();
                            int a = 0;
                            while (server.Server.IsProcessRun() == true)
                            {
                                Thread.Sleep(1000);
                                a++;
                                if (a >= 180)
                                {
                                    server.Server.Close();
                                }
                            }
                        }
                    });
                }
            }
        }
        //双击托盘图标
        private void APP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
        //窗口最小化
        private void APP_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
                icon.ShowBalloonTip(1000, "提示", "软件已最小化，单击我还原", ToolTipIcon.Info);
            }
        }
        private void APP_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                while (Start.is_close == false)
                {
                    if (Start.updata == true)
                    {
                        Action<int> action = (data) =>
                        {
                            listServer.Items.Clear();
                            Dictionary<string, Config_class>.ValueCollection servers = Config_file.server_list.Values;
                            foreach (Config_class server in servers)
                            {
                                ListViewItem test = new ListViewItem(server.server_name);
                                if (server.Server != null)
                                    switch (server.Server.server_now)
                                    {
                                        case 0:
                                            test.SubItems.Add("关闭");
                                            break;
                                        case 1:
                                            test.SubItems.Add("开启中");
                                            break;
                                        case 2:
                                            test.SubItems.Add("运行中");
                                            break;
                                    }
                                else
                                    test.SubItems.Add("关闭");
                                test.SubItems.Add(server.server_core);
                                test.SubItems.Add(server.java_arg);
                                listServer.Items.Add(test);
                            }
                            Thread.Sleep(1000);
                        };
                        Invoke(action, 0);
                        Start.updata = false;
                    }
                    Thread.Sleep(10);
                }
            });
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Add_Server add = new Add_Server();
            add.ShowDialog();
        }
        private void Open_win_Click(object sender, EventArgs e)
        {
            if (listServer.SelectedItems.Count == 0)
                MessageBox.Show("请选择一个服务器");
            else if (Config_file.server_list.ContainsKey(listServer.SelectedItems[0].Text))
            {
                Config_class server = Config_file.server_list[listServer.SelectedItems[0].Text];
                if (server.Server == null && server.form == null)
                {
                    server.form = new Window_Main(server);
                    server.form.Show();
                }
                else
                    server.form.Show();
            }
        }

        private void Delete_server_Click(object sender, EventArgs e)
        {
            if (listServer.SelectedItems.Count == 0)
                MessageBox.Show("请选择一个服务器");
            else if (Config_file.server_list.ContainsKey(listServer.SelectedItems[0].Text))
            {
                Config_class server = Config_file.server_list[listServer.SelectedItems[0].Text];
                if (server.Server == null && server.form == null)
                {
                    Config_write.delete_server(Start.APP_local + Config_file.server, server);
                }
                else if(server.Server.IsProcessRun() == true)
                {
                    if (MessageBox.Show("服务器正在运行，是否先关闭服务器再删除", "服务器在运行", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (server.Task_list != null)
                            server.Task_list.StopTask();
                        if (server.Server != null && server.Server.IsProcessRun() == true)
                        {
                            server.Server.Stop();
                            int a = 0;
                            while (server.Server.IsProcessRun() == true)
                            {
                                Thread.Sleep(1000);
                                a++;
                                if (a >= 180)
                                {
                                    server.Server.Close();
                                }
                            }
                        }
                    }
                }
                Config_file.server_list.Remove(server.server_name);
                Start.updata = true;
            }
        }
    }
}
