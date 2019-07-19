using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minecraft_Server_QQ.WinAPI;

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
            Dictionary<string, server_save>.ValueCollection temp = config_file.server_list.Values;
            foreach (server_save a in temp)
            {
                if (a.server_name == server_name.Text)
                {
                    MessageBox.Show("服务器名已存在，请更换");
                    return;
                }
                else if (a.server_local == server_local.Text)
                {
                    MessageBox.Show("服务器名已存在，请更换");
                    return;
                }
            }
            try
            {
                server_save server = new server_save();
                server.server_name = server_name.Text;
                server.server_local = server_local.Text;
                server.server_core = server_core.Text;
                server.java_local = java_local.Text;
                server.java_arg = java_arg.Text;
                server.auto_restart = auto_restart.Checked;
                server.open_start = open_start.Checked;
                server.min_m = (int)java_min.Value;
                server.max_m = (int)java_max.Value;
                config_write.write_server(Start.APP_local + config_file.server, server);
                config_file.server_list.Add(server.server_name, server);
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
            MEMORYSTATUS1 vBuffer = new MEMORYSTATUS1();//实例化结构  
            vBuffer.dwLength = 64;
            GlobalMemoryStatusEx(ref vBuffer);//给此结构赋值搜索            
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
