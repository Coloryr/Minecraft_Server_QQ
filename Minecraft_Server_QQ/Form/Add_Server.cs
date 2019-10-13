using Minecraft_Server_QQ.Config;
using Minecraft_Server_QQ.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft_Server_QQ
{
    partial class Add_Server : Form
    {
        public Add_Server()
        {
            InitializeComponent();
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

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(server_name.Text)
                || string.IsNullOrWhiteSpace(server_local.Text)
                || string.IsNullOrWhiteSpace(server_core.Text))
            {
                MessageBox.Show("参数缺少，请检查");
                return;
            }
            Dictionary<string, Server_Save>.ValueCollection temp = Config_file.server_list.Values;
            foreach (Server_Save a in temp)
            {
                if (a.Config.server_name == server_name.Text)
                {
                    MessageBox.Show("服务器名已存在，请更换");
                    return;
                }
                else if (a.Config.server_local == server_local.Text)
                {
                    MessageBox.Show("服务器名已存在，请更换");
                    return;
                }
            }
            try
            {
                Server_Save server = new Server_Save()
                {
                    Config = new Server_Config()
                    {
                        server_name = server_name.Text,
                        server_local = server_local.Text,
                        server_core = server_core.Text,
                        java_local = java_local.Text,
                        java_arg = java_arg.Text,
                        auto_restart = auto_restart.Checked,
                        open_start = open_start.Checked,
                        min_m = (int)java_min.Value,
                        max_m = (int)java_max.Value
                    }
                };
                Config_write.write_server(Start.APP_local + Config_file.server, server);
                Config_file.server_list.Add(server.Config.server_name, server);
                MessageBox.Show("已添加");
                Start.updata = true;
                Close();
            }
            catch (Exception ex)
            {
                logs.Log_write("[ERROR]" + ex.Message);
            }
        }

        private void Add_Server_Load(object sender, EventArgs e)
        {
            WinAPI.MEMORYSTATUS1 vBuffer = new WinAPI.MEMORYSTATUS1();//实例化结构  
            vBuffer.dwLength = 64;
            WinAPI.GlobalMemoryStatusEx(ref vBuffer);//给此结构赋值搜索            
            long max_m = vBuffer.ullTotalPhys / 1024 / 1024;
            java_max.Maximum = max_m;
            java_min.Maximum = max_m;
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
    }
}
