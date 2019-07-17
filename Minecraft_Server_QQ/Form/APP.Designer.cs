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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listServer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_tuopan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务器并退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip_tuopan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用 ENCP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器列表";
            // 
            // listServer
            // 
            this.listServer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listServer.FullRowSelect = true;
            this.listServer.GridLines = true;
            this.listServer.HideSelection = false;
            this.listServer.Location = new System.Drawing.Point(3, 17);
            this.listServer.MultiSelect = false;
            this.listServer.Name = "listServer";
            this.listServer.Size = new System.Drawing.Size(472, 293);
            this.listServer.TabIndex = 1;
            this.listServer.UseCompatibleStateImageBehavior = false;
            this.listServer.View = System.Windows.Forms.View.Details;
            this.listServer.SelectedIndexChanged += new System.EventHandler(this.ListServer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "服务器名称";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "当前状态";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "本地文件名";
            this.columnHeader4.Width = 218;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "全部开启";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "全部关闭";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "添加服务器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip_tuopan;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MinecraftServerGUI";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip_tuopan
            // 
            this.contextMenuStrip_tuopan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示窗口ToolStripMenuItem,
            this.开启服务器ToolStripMenuItem,
            this.关闭服务器ToolStripMenuItem,
            this.重启服务器ToolStripMenuItem,
            this.关闭服务器并退出程序ToolStripMenuItem});
            this.contextMenuStrip_tuopan.Name = "contextMenuStrip_tuopan";
            this.contextMenuStrip_tuopan.Size = new System.Drawing.Size(197, 114);
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
            this.ClientSize = new System.Drawing.Size(502, 386);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "APP";
            this.Text = "APP";
            this.Load += new System.EventHandler(this.APP_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip_tuopan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listServer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_tuopan;
        private System.Windows.Forms.ToolStripMenuItem 显示窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务器并退出程序ToolStripMenuItem;
    }
}