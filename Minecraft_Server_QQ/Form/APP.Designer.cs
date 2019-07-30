namespace Minecraft_Server_QQ
{
    partial class APP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listServer = new System.Windows.Forms.ListView();
            this.server_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.server_now = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.server_core = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.java_arg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.server_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete_server = new System.Windows.Forms.ToolStripMenuItem();
            this.open_win = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.app_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务器并退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.server_menu.SuspendLayout();
            this.app_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用 Minecraft_Server_QQ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listServer);
            this.groupBox1.Location = new System.Drawing.Point(-2, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器列表";
            // 
            // listServer
            // 
            this.listServer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.server_name,
            this.server_now,
            this.server_core,
            this.java_arg});
            this.listServer.ContextMenuStrip = this.server_menu;
            this.listServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listServer.FullRowSelect = true;
            this.listServer.GridLines = true;
            this.listServer.HideSelection = false;
            this.listServer.Location = new System.Drawing.Point(3, 17);
            this.listServer.MultiSelect = false;
            this.listServer.Name = "listServer";
            this.listServer.Size = new System.Drawing.Size(498, 293);
            this.listServer.TabIndex = 1;
            this.listServer.UseCompatibleStateImageBehavior = false;
            this.listServer.View = System.Windows.Forms.View.Details;
            this.listServer.DoubleClick += new System.EventHandler(this.Open_win_Click);
            // 
            // server_name
            // 
            this.server_name.Text = "服务器名称";
            this.server_name.Width = 81;
            // 
            // server_now
            // 
            this.server_now.Text = "当前状态";
            this.server_now.Width = 64;
            // 
            // server_core
            // 
            this.server_core.Text = "服务器核心名字";
            this.server_core.Width = 104;
            // 
            // java_arg
            // 
            this.java_arg.Text = "JAVA参数";
            this.java_arg.Width = 245;
            // 
            // server_menu
            // 
            this.server_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_server,
            this.open_win});
            this.server_menu.Name = "contextMenuStrip_tuopan";
            this.server_menu.Size = new System.Drawing.Size(137, 48);
            // 
            // delete_server
            // 
            this.delete_server.Name = "delete_server";
            this.delete_server.Size = new System.Drawing.Size(136, 22);
            this.delete_server.Text = "删除服务器";
            this.delete_server.Click += new System.EventHandler(this.Delete_server_Click);
            // 
            // open_win
            // 
            this.open_win.Name = "open_win";
            this.open_win.Size = new System.Drawing.Size(136, 22);
            this.open_win.Text = "打开控制台";
            this.open_win.Click += new System.EventHandler(this.Open_win_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "全部开启";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "全部关闭";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "添加服务器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.app_menu;
            this.icon.Icon = global::Minecraft_Server_QQ.Properties.Resources.Color_yr;
            this.icon.Text = "Minecraft_Server_QQ";
            this.icon.Visible = true;
            this.icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.APP_MouseDoubleClick);
            // 
            // app_menu
            // 
            this.app_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示窗口ToolStripMenuItem,
            this.开启服务器ToolStripMenuItem,
            this.关闭服务器ToolStripMenuItem,
            this.重启服务器ToolStripMenuItem,
            this.关闭服务器并退出程序ToolStripMenuItem});
            this.app_menu.Name = "contextMenuStrip_tuopan";
            this.app_menu.Size = new System.Drawing.Size(197, 114);
            // 
            // 显示窗口ToolStripMenuItem
            // 
            this.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem";
            this.显示窗口ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.显示窗口ToolStripMenuItem.Text = "显示窗口";
            // 
            // 开启服务器ToolStripMenuItem
            // 
            this.开启服务器ToolStripMenuItem.Name = "开启服务器ToolStripMenuItem";
            this.开启服务器ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.开启服务器ToolStripMenuItem.Text = "开启服务器";
            // 
            // 关闭服务器ToolStripMenuItem
            // 
            this.关闭服务器ToolStripMenuItem.Name = "关闭服务器ToolStripMenuItem";
            this.关闭服务器ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.关闭服务器ToolStripMenuItem.Text = "关闭服务器";
            // 
            // 重启服务器ToolStripMenuItem
            // 
            this.重启服务器ToolStripMenuItem.Name = "重启服务器ToolStripMenuItem";
            this.重启服务器ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.重启服务器ToolStripMenuItem.Text = "重启服务器";
            // 
            // 关闭服务器并退出程序ToolStripMenuItem
            // 
            this.关闭服务器并退出程序ToolStripMenuItem.Name = "关闭服务器并退出程序ToolStripMenuItem";
            this.关闭服务器并退出程序ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.关闭服务器并退出程序ToolStripMenuItem.Text = "关闭服务器并退出程序";
            // 
            // APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 366);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Minecraft_Server_QQ.Properties.Resources.Color_yr;
            this.MaximizeBox = false;
            this.Name = "APP";
            this.Text = "Minecraft_Server_QQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.APP_Closing);
            this.Load += new System.EventHandler(this.APP_Load);
            this.Resize += new System.EventHandler(this.APP_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.server_menu.ResumeLayout(false);
            this.app_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listServer;
        private System.Windows.Forms.ColumnHeader server_name;
        private System.Windows.Forms.ColumnHeader server_now;
        private System.Windows.Forms.ColumnHeader server_core;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.ContextMenuStrip app_menu;
        private System.Windows.Forms.ToolStripMenuItem 显示窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务器并退出程序ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader java_arg;
        private System.Windows.Forms.ContextMenuStrip server_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_server;
        private System.Windows.Forms.ToolStripMenuItem open_win;
    }
}