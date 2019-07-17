using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void ListServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //双击托盘图标
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }
        //窗口最小化
        private void Window_Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.ShowBalloonTip(1000, "提示", "软件已最小化，双击我还原", ToolTipIcon.Info);
            }
        }

        private void APP_Load(object sender, EventArgs e)
        {
            //listServer.Items.Add();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Add_Server add = new Add_Server();
            add.ShowDialog();
        }
    }
}
