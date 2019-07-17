namespace Minecraft_Server_QQ
{
    partial class Window_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage_Server = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_javaCanShu = new System.Windows.Forms.TextBox();
            this.textBox_MoreLine = new System.Windows.Forms.TextBox();
            this.textBox_javaPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_49 = new System.Windows.Forms.Label();
            this.button_autoSeach = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.label_48 = new System.Windows.Forms.Label();
            this.groupBox_52 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MaxMemory = new System.Windows.Forms.TextBox();
            this.label_54 = new System.Windows.Forms.Label();
            this.tabPage_serverTask = new System.Windows.Forms.TabPage();
            this.groupBox_41 = new System.Windows.Forms.GroupBox();
            this.listView_Task = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_serverMod = new System.Windows.Forms.TabPage();
            this.groupBox_68 = new System.Windows.Forms.GroupBox();
            this.listView_mods = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_serverPlugin = new System.Windows.Forms.TabPage();
            this.groupBox_32 = new System.Windows.Forms.GroupBox();
            this.listView_plugins = new System.Windows.Forms.ListView();
            this.plugin_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plugin_vision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plugin_auth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pulgin_file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_serverSet = new System.Windows.Forms.TabPage();
            this.button_saveServerSet = new System.Windows.Forms.Button();
            this.button_readServerSet = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage_serverInfo = new System.Windows.Forms.TabPage();
            this.button_serverStop = new System.Windows.Forms.Button();
            this.button_serverClose = new System.Windows.Forms.Button();
            this.button_serverRest = new System.Windows.Forms.Button();
            this.button_serverRun = new System.Windows.Forms.Button();
            this.groupBox_25 = new System.Windows.Forms.GroupBox();
            this.textBox_sendServer = new System.Windows.Forms.TextBox();
            this.textBox_serverInfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Server.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_52.SuspendLayout();
            this.tabPage_serverTask.SuspendLayout();
            this.groupBox_41.SuspendLayout();
            this.tabPage_serverMod.SuspendLayout();
            this.groupBox_68.SuspendLayout();
            this.tabPage_serverPlugin.SuspendLayout();
            this.groupBox_32.SuspendLayout();
            this.tabPage_serverSet.SuspendLayout();
            this.tabPage_serverInfo.SuspendLayout();
            this.groupBox_25.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // tabPage_Server
            // 
            this.tabPage_Server.Controls.Add(this.button1);
            this.tabPage_Server.Controls.Add(this.groupBox1);
            this.tabPage_Server.Controls.Add(this.groupBox_52);
            this.tabPage_Server.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Server.Name = "tabPage_Server";
            this.tabPage_Server.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Server.Size = new System.Drawing.Size(637, 341);
            this.tabPage_Server.TabIndex = 7;
            this.tabPage_Server.Text = "服务器设置";
            this.tabPage_Server.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_javaCanShu);
            this.groupBox1.Controls.Add(this.textBox_MoreLine);
            this.groupBox1.Controls.Add(this.textBox_javaPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_49);
            this.groupBox1.Controls.Add(this.button_autoSeach);
            this.groupBox1.Controls.Add(this.button_select);
            this.groupBox1.Controls.Add(this.label_48);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 92);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "启动设置";
            // 
            // textBox_javaCanShu
            // 
            this.textBox_javaCanShu.Location = new System.Drawing.Point(90, 39);
            this.textBox_javaCanShu.Name = "textBox_javaCanShu";
            this.textBox_javaCanShu.Size = new System.Drawing.Size(529, 21);
            this.textBox_javaCanShu.TabIndex = 39;
            // 
            // textBox_MoreLine
            // 
            this.textBox_MoreLine.Location = new System.Drawing.Point(90, 64);
            this.textBox_MoreLine.Name = "textBox_MoreLine";
            this.textBox_MoreLine.Size = new System.Drawing.Size(529, 21);
            this.textBox_MoreLine.TabIndex = 37;
            // 
            // textBox_javaPath
            // 
            this.textBox_javaPath.Location = new System.Drawing.Point(89, 12);
            this.textBox_javaPath.Name = "textBox_javaPath";
            this.textBox_javaPath.Size = new System.Drawing.Size(370, 21);
            this.textBox_javaPath.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "附加Java参数";
            // 
            // label_49
            // 
            this.label_49.AutoSize = true;
            this.label_49.Location = new System.Drawing.Point(7, 67);
            this.label_49.Name = "label_49";
            this.label_49.Size = new System.Drawing.Size(77, 12);
            this.label_49.TabIndex = 36;
            this.label_49.Text = "附加启动参数";
            // 
            // button_autoSeach
            // 
            this.button_autoSeach.Location = new System.Drawing.Point(465, 12);
            this.button_autoSeach.Name = "button_autoSeach";
            this.button_autoSeach.Size = new System.Drawing.Size(75, 23);
            this.button_autoSeach.TabIndex = 34;
            this.button_autoSeach.Text = "自动搜索";
            this.button_autoSeach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_autoSeach.UseVisualStyleBackColor = true;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(546, 12);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(73, 23);
            this.button_select.TabIndex = 35;
            this.button_select.Text = "手动选择";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // label_48
            // 
            this.label_48.AutoSize = true;
            this.label_48.Location = new System.Drawing.Point(7, 17);
            this.label_48.Name = "label_48";
            this.label_48.Size = new System.Drawing.Size(77, 12);
            this.label_48.TabIndex = 32;
            this.label_48.Text = "设置JAVA路径";
            // 
            // groupBox_52
            // 
            this.groupBox_52.Controls.Add(this.textBox1);
            this.groupBox_52.Controls.Add(this.label2);
            this.groupBox_52.Controls.Add(this.textBox_MaxMemory);
            this.groupBox_52.Controls.Add(this.label_54);
            this.groupBox_52.Location = new System.Drawing.Point(6, 104);
            this.groupBox_52.Name = "groupBox_52";
            this.groupBox_52.Size = new System.Drawing.Size(267, 71);
            this.groupBox_52.TabIndex = 15;
            this.groupBox_52.TabStop = false;
            this.groupBox_52.Text = "分配内存";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "服务端最小内存(MB):";
            // 
            // textBox_MaxMemory
            // 
            this.textBox_MaxMemory.Location = new System.Drawing.Point(132, 13);
            this.textBox_MaxMemory.Name = "textBox_MaxMemory";
            this.textBox_MaxMemory.Size = new System.Drawing.Size(128, 21);
            this.textBox_MaxMemory.TabIndex = 3;
            // 
            // label_54
            // 
            this.label_54.AutoSize = true;
            this.label_54.Location = new System.Drawing.Point(7, 16);
            this.label_54.Name = "label_54";
            this.label_54.Size = new System.Drawing.Size(119, 12);
            this.label_54.TabIndex = 1;
            this.label_54.Text = "服务端最大内存(MB):";
            // 
            // tabPage_serverTask
            // 
            this.tabPage_serverTask.Controls.Add(this.groupBox_41);
            this.tabPage_serverTask.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverTask.Name = "tabPage_serverTask";
            this.tabPage_serverTask.Size = new System.Drawing.Size(637, 341);
            this.tabPage_serverTask.TabIndex = 4;
            this.tabPage_serverTask.Text = "计划任务";
            this.tabPage_serverTask.UseVisualStyleBackColor = true;
            // 
            // groupBox_41
            // 
            this.groupBox_41.Controls.Add(this.listView_Task);
            this.groupBox_41.Location = new System.Drawing.Point(3, 3);
            this.groupBox_41.Name = "groupBox_41";
            this.groupBox_41.Size = new System.Drawing.Size(631, 335);
            this.groupBox_41.TabIndex = 3;
            this.groupBox_41.TabStop = false;
            this.groupBox_41.Text = "计划任务(右键可管理任务/点我添加任务)";
            this.groupBox_41.Enter += new System.EventHandler(this.GroupBox_41_Enter);
            // 
            // listView_Task
            // 
            this.listView_Task.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Task.FullRowSelect = true;
            this.listView_Task.GridLines = true;
            this.listView_Task.HideSelection = false;
            this.listView_Task.Location = new System.Drawing.Point(3, 17);
            this.listView_Task.MultiSelect = false;
            this.listView_Task.Name = "listView_Task";
            this.listView_Task.Size = new System.Drawing.Size(625, 315);
            this.listView_Task.TabIndex = 0;
            this.listView_Task.UseCompatibleStateImageBehavior = false;
            this.listView_Task.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "任务序号";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "任务内容";
            this.columnHeader10.Width = 450;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "重复周期";
            this.columnHeader11.Width = 111;
            // 
            // tabPage_serverMod
            // 
            this.tabPage_serverMod.Controls.Add(this.groupBox_68);
            this.tabPage_serverMod.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverMod.Name = "tabPage_serverMod";
            this.tabPage_serverMod.Size = new System.Drawing.Size(637, 341);
            this.tabPage_serverMod.TabIndex = 3;
            this.tabPage_serverMod.Text = "服务器MOD";
            this.tabPage_serverMod.UseVisualStyleBackColor = true;
            // 
            // groupBox_68
            // 
            this.groupBox_68.Controls.Add(this.listView_mods);
            this.groupBox_68.Location = new System.Drawing.Point(3, 3);
            this.groupBox_68.Name = "groupBox_68";
            this.groupBox_68.Size = new System.Drawing.Size(631, 335);
            this.groupBox_68.TabIndex = 2;
            this.groupBox_68.TabStop = false;
            this.groupBox_68.Text = "服务器MOD(右键可管理MOD)";
            // 
            // listView_mods
            // 
            this.listView_mods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader4});
            this.listView_mods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_mods.FullRowSelect = true;
            this.listView_mods.GridLines = true;
            this.listView_mods.HideSelection = false;
            this.listView_mods.Location = new System.Drawing.Point(3, 17);
            this.listView_mods.MultiSelect = false;
            this.listView_mods.Name = "listView_mods";
            this.listView_mods.Size = new System.Drawing.Size(625, 315);
            this.listView_mods.TabIndex = 0;
            this.listView_mods.UseCompatibleStateImageBehavior = false;
            this.listView_mods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MOD名称";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MOD版本";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "安装时间";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "本地文件名";
            this.columnHeader4.Width = 170;
            // 
            // tabPage_serverPlugin
            // 
            this.tabPage_serverPlugin.Controls.Add(this.groupBox_32);
            this.tabPage_serverPlugin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverPlugin.Name = "tabPage_serverPlugin";
            this.tabPage_serverPlugin.Size = new System.Drawing.Size(637, 341);
            this.tabPage_serverPlugin.TabIndex = 2;
            this.tabPage_serverPlugin.Text = "服务器插件";
            this.tabPage_serverPlugin.UseVisualStyleBackColor = true;
            // 
            // groupBox_32
            // 
            this.groupBox_32.Controls.Add(this.listView_plugins);
            this.groupBox_32.Location = new System.Drawing.Point(3, 3);
            this.groupBox_32.Name = "groupBox_32";
            this.groupBox_32.Size = new System.Drawing.Size(631, 335);
            this.groupBox_32.TabIndex = 0;
            this.groupBox_32.TabStop = false;
            this.groupBox_32.Text = "服务器插件(右键可管理插件)";
            // 
            // listView_plugins
            // 
            this.listView_plugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.plugin_name,
            this.plugin_vision,
            this.plugin_auth,
            this.pulgin_file});
            this.listView_plugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_plugins.FullRowSelect = true;
            this.listView_plugins.GridLines = true;
            this.listView_plugins.HideSelection = false;
            this.listView_plugins.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_plugins.Location = new System.Drawing.Point(3, 17);
            this.listView_plugins.MultiSelect = false;
            this.listView_plugins.Name = "listView_plugins";
            this.listView_plugins.Size = new System.Drawing.Size(625, 315);
            this.listView_plugins.TabIndex = 1;
            this.listView_plugins.UseCompatibleStateImageBehavior = false;
            this.listView_plugins.View = System.Windows.Forms.View.Details;
            this.listView_plugins.SelectedIndexChanged += new System.EventHandler(this.ListView_plugins_SelectedIndexChanged);
            // 
            // plugin_name
            // 
            this.plugin_name.Text = "插件名称";
            this.plugin_name.Width = 150;
            // 
            // plugin_vision
            // 
            this.plugin_vision.Text = "插件版本";
            this.plugin_vision.Width = 100;
            // 
            // plugin_auth
            // 
            this.plugin_auth.Text = "作者";
            this.plugin_auth.Width = 115;
            // 
            // pulgin_file
            // 
            this.pulgin_file.Text = "本地名";
            this.pulgin_file.Width = 256;
            // 
            // tabPage_serverSet
            // 
            this.tabPage_serverSet.Controls.Add(this.button_saveServerSet);
            this.tabPage_serverSet.Controls.Add(this.button_readServerSet);
            this.tabPage_serverSet.Controls.Add(this.propertyGrid1);
            this.tabPage_serverSet.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverSet.Name = "tabPage_serverSet";
            this.tabPage_serverSet.Size = new System.Drawing.Size(637, 341);
            this.tabPage_serverSet.TabIndex = 1;
            this.tabPage_serverSet.Text = "服务器配置文件";
            this.tabPage_serverSet.UseVisualStyleBackColor = true;
            // 
            // button_saveServerSet
            // 
            this.button_saveServerSet.Location = new System.Drawing.Point(358, 286);
            this.button_saveServerSet.Name = "button_saveServerSet";
            this.button_saveServerSet.Size = new System.Drawing.Size(222, 36);
            this.button_saveServerSet.TabIndex = 2;
            this.button_saveServerSet.Text = "保存当前设置";
            this.button_saveServerSet.UseVisualStyleBackColor = true;
            this.button_saveServerSet.Click += new System.EventHandler(this.button_saveServerSet_Click);
            // 
            // button_readServerSet
            // 
            this.button_readServerSet.Location = new System.Drawing.Point(51, 286);
            this.button_readServerSet.Name = "button_readServerSet";
            this.button_readServerSet.Size = new System.Drawing.Size(222, 36);
            this.button_readServerSet.TabIndex = 1;
            this.button_readServerSet.Text = "立即刷新设置";
            this.button_readServerSet.UseVisualStyleBackColor = true;
            this.button_readServerSet.Click += new System.EventHandler(this.button_readServerSet_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(631, 277);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.ToolbarVisible = false;
            this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // tabPage_serverInfo
            // 
            this.tabPage_serverInfo.Controls.Add(this.button_serverStop);
            this.tabPage_serverInfo.Controls.Add(this.button_serverClose);
            this.tabPage_serverInfo.Controls.Add(this.button_serverRest);
            this.tabPage_serverInfo.Controls.Add(this.button_serverRun);
            this.tabPage_serverInfo.Controls.Add(this.groupBox_25);
            this.tabPage_serverInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverInfo.Name = "tabPage_serverInfo";
            this.tabPage_serverInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_serverInfo.Size = new System.Drawing.Size(637, 341);
            this.tabPage_serverInfo.TabIndex = 0;
            this.tabPage_serverInfo.Text = "服务器信息";
            this.tabPage_serverInfo.UseVisualStyleBackColor = true;
            // 
            // button_serverStop
            // 
            this.button_serverStop.Enabled = false;
            this.button_serverStop.Location = new System.Drawing.Point(164, 290);
            this.button_serverStop.Name = "button_serverStop";
            this.button_serverStop.Size = new System.Drawing.Size(146, 29);
            this.button_serverStop.TabIndex = 2;
            this.button_serverStop.Text = "关闭服务器";
            this.button_serverStop.UseVisualStyleBackColor = true;
            this.button_serverStop.Click += new System.EventHandler(this.button_serverStop_Click);
            // 
            // button_serverClose
            // 
            this.button_serverClose.Location = new System.Drawing.Point(479, 290);
            this.button_serverClose.Name = "button_serverClose";
            this.button_serverClose.Size = new System.Drawing.Size(146, 29);
            this.button_serverClose.TabIndex = 4;
            this.button_serverClose.Text = "强制关闭服务器";
            this.button_serverClose.UseVisualStyleBackColor = true;
            this.button_serverClose.Click += new System.EventHandler(this.button_serverClose_Click);
            // 
            // button_serverRest
            // 
            this.button_serverRest.Enabled = false;
            this.button_serverRest.Location = new System.Drawing.Point(327, 290);
            this.button_serverRest.Name = "button_serverRest";
            this.button_serverRest.Size = new System.Drawing.Size(146, 29);
            this.button_serverRest.TabIndex = 3;
            this.button_serverRest.Text = "重启服务器";
            this.button_serverRest.UseVisualStyleBackColor = true;
            this.button_serverRest.Click += new System.EventHandler(this.button_serverRest_Click);
            // 
            // button_serverRun
            // 
            this.button_serverRun.Location = new System.Drawing.Point(12, 290);
            this.button_serverRun.Name = "button_serverRun";
            this.button_serverRun.Size = new System.Drawing.Size(146, 29);
            this.button_serverRun.TabIndex = 1;
            this.button_serverRun.Text = "开启服务器";
            this.button_serverRun.UseVisualStyleBackColor = true;
            this.button_serverRun.Click += new System.EventHandler(this.button_serverRun_Click);
            // 
            // groupBox_25
            // 
            this.groupBox_25.Controls.Add(this.textBox_sendServer);
            this.groupBox_25.Controls.Add(this.textBox_serverInfo);
            this.groupBox_25.Location = new System.Drawing.Point(6, 3);
            this.groupBox_25.Name = "groupBox_25";
            this.groupBox_25.Size = new System.Drawing.Size(625, 281);
            this.groupBox_25.TabIndex = 0;
            this.groupBox_25.TabStop = false;
            this.groupBox_25.Text = "服务端信息";
            // 
            // textBox_sendServer
            // 
            this.textBox_sendServer.ForeColor = System.Drawing.Color.Gray;
            this.textBox_sendServer.Location = new System.Drawing.Point(6, 254);
            this.textBox_sendServer.Name = "textBox_sendServer";
            this.textBox_sendServer.Size = new System.Drawing.Size(613, 21);
            this.textBox_sendServer.TabIndex = 1;
            this.textBox_sendServer.Enter += new System.EventHandler(this.textBox_sendServer_Enter);
            this.textBox_sendServer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_sendServer_KeyUp);
            this.textBox_sendServer.Leave += new System.EventHandler(this.textBox_sendServer_Leave);
            // 
            // textBox_serverInfo
            // 
            this.textBox_serverInfo.Location = new System.Drawing.Point(6, 20);
            this.textBox_serverInfo.Multiline = true;
            this.textBox_serverInfo.Name = "textBox_serverInfo";
            this.textBox_serverInfo.ReadOnly = true;
            this.textBox_serverInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_serverInfo.Size = new System.Drawing.Size(613, 228);
            this.textBox_serverInfo.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_serverInfo);
            this.tabControl1.Controls.Add(this.tabPage_serverSet);
            this.tabControl1.Controls.Add(this.tabPage_serverPlugin);
            this.tabControl1.Controls.Add(this.tabPage_serverMod);
            this.tabControl1.Controls.Add(this.tabPage_serverTask);
            this.tabControl1.Controls.Add(this.tabPage_Server);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 367);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_SelectingAsync);
            // 
            // Window_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(669, 391);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End Land Control Pad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_Main_FormClosing);
            this.Load += new System.EventHandler(this.Window_Main_Load);
            this.tabPage_Server.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_52.ResumeLayout(false);
            this.groupBox_52.PerformLayout();
            this.tabPage_serverTask.ResumeLayout(false);
            this.groupBox_41.ResumeLayout(false);
            this.tabPage_serverMod.ResumeLayout(false);
            this.groupBox_68.ResumeLayout(false);
            this.tabPage_serverPlugin.ResumeLayout(false);
            this.groupBox_32.ResumeLayout(false);
            this.tabPage_serverSet.ResumeLayout(false);
            this.tabPage_serverInfo.ResumeLayout(false);
            this.groupBox_25.ResumeLayout(false);
            this.groupBox_25.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage_Server;
        private System.Windows.Forms.GroupBox groupBox_52;
        private System.Windows.Forms.TextBox textBox_MaxMemory;
        private System.Windows.Forms.Label label_54;
        private System.Windows.Forms.TabPage tabPage_serverTask;
        private System.Windows.Forms.GroupBox groupBox_41;
        private System.Windows.Forms.ListView listView_Task;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabPage tabPage_serverMod;
        private System.Windows.Forms.GroupBox groupBox_68;
        private System.Windows.Forms.ListView listView_mods;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage_serverPlugin;
        private System.Windows.Forms.GroupBox groupBox_32;
        private System.Windows.Forms.ListView listView_plugins;
        private System.Windows.Forms.ColumnHeader plugin_name;
        private System.Windows.Forms.ColumnHeader plugin_vision;
        private System.Windows.Forms.ColumnHeader plugin_auth;
        private System.Windows.Forms.ColumnHeader pulgin_file;
        private System.Windows.Forms.TabPage tabPage_serverSet;
        private System.Windows.Forms.Button button_saveServerSet;
        private System.Windows.Forms.Button button_readServerSet;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabPage tabPage_serverInfo;
        private System.Windows.Forms.Button button_serverStop;
        private System.Windows.Forms.Button button_serverClose;
        private System.Windows.Forms.Button button_serverRest;
        private System.Windows.Forms.Button button_serverRun;
        private System.Windows.Forms.GroupBox groupBox_25;
        private System.Windows.Forms.TextBox textBox_sendServer;
        private System.Windows.Forms.TextBox textBox_serverInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_javaCanShu;
        private System.Windows.Forms.TextBox textBox_MoreLine;
        private System.Windows.Forms.TextBox textBox_javaPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_49;
        private System.Windows.Forms.Button button_autoSeach;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label_48;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

