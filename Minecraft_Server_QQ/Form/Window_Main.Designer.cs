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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.tabPage_Server = new System.Windows.Forms.TabPage();
            this.open_start = new System.Windows.Forms.CheckBox();
            this.auto_restart = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_java_auto = new System.Windows.Forms.Button();
            this.java_max = new System.Windows.Forms.NumericUpDown();
            this.java_min = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_java = new System.Windows.Forms.Button();
            this.java_arg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.java_local = new System.Windows.Forms.TextBox();
            this.server_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_server_core = new System.Windows.Forms.Button();
            this.server_core = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.server_arg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.server_local = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.config = new System.Windows.Forms.PropertyGrid();
            this.tabPage_serverInfo = new System.Windows.Forms.TabPage();
            this.button_serverStop = new System.Windows.Forms.Button();
            this.button_serverClose = new System.Windows.Forms.Button();
            this.button_serverRest = new System.Windows.Forms.Button();
            this.button_serverRun = new System.Windows.Forms.Button();
            this.groupBox_25 = new System.Windows.Forms.GroupBox();
            this.textBox_sendServer = new System.Windows.Forms.TextBox();
            this.textBox_serverInfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.java_local_chose = new System.Windows.Forms.OpenFileDialog();
            this.server_local_core = new System.Windows.Forms.OpenFileDialog();
            this.tabPage_Server.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.java_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.java_min)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // tabPage_Server
            // 
            this.tabPage_Server.Controls.Add(this.open_start);
            this.tabPage_Server.Controls.Add(this.auto_restart);
            this.tabPage_Server.Controls.Add(this.groupBox2);
            this.tabPage_Server.Controls.Add(this.server_name);
            this.tabPage_Server.Controls.Add(this.label4);
            this.tabPage_Server.Controls.Add(this.groupBox1);
            this.tabPage_Server.Controls.Add(this.button1);
            this.tabPage_Server.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Server.Name = "tabPage_Server";
            this.tabPage_Server.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Server.Size = new System.Drawing.Size(656, 365);
            this.tabPage_Server.TabIndex = 7;
            this.tabPage_Server.Text = "服务器设置";
            this.tabPage_Server.UseVisualStyleBackColor = true;
            // 
            // open_start
            // 
            this.open_start.AutoSize = true;
            this.open_start.Location = new System.Drawing.Point(110, 341);
            this.open_start.Name = "open_start";
            this.open_start.Size = new System.Drawing.Size(120, 16);
            this.open_start.TabIndex = 47;
            this.open_start.Text = "开启软件自动开服";
            this.open_start.UseVisualStyleBackColor = true;
            // 
            // auto_restart
            // 
            this.auto_restart.AutoSize = true;
            this.auto_restart.Location = new System.Drawing.Point(8, 341);
            this.auto_restart.Name = "auto_restart";
            this.auto_restart.Size = new System.Drawing.Size(96, 16);
            this.auto_restart.TabIndex = 46;
            this.auto_restart.Text = "崩溃自动重启";
            this.auto_restart.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_java_auto);
            this.groupBox2.Controls.Add(this.java_max);
            this.groupBox2.Controls.Add(this.java_min);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_java);
            this.groupBox2.Controls.Add(this.java_arg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.java_local);
            this.groupBox2.Location = new System.Drawing.Point(0, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 126);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JAVA设置";
            // 
            // button_java_auto
            // 
            this.button_java_auto.Location = new System.Drawing.Point(350, 101);
            this.button_java_auto.Name = "button_java_auto";
            this.button_java_auto.Size = new System.Drawing.Size(150, 24);
            this.button_java_auto.TabIndex = 14;
            this.button_java_auto.Text = "自动查找JAVA";
            this.button_java_auto.UseVisualStyleBackColor = true;
            this.button_java_auto.Click += new System.EventHandler(this.Button_java_auto_Click);
            // 
            // java_max
            // 
            this.java_max.Location = new System.Drawing.Point(308, 74);
            this.java_max.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.java_max.Name = "java_max";
            this.java_max.Size = new System.Drawing.Size(94, 21);
            this.java_max.TabIndex = 12;
            this.java_max.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // java_min
            // 
            this.java_min.Location = new System.Drawing.Point(101, 74);
            this.java_min.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.java_min.Name = "java_min";
            this.java_min.Size = new System.Drawing.Size(94, 21);
            this.java_min.TabIndex = 11;
            this.java_min.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "JAVA最大内存";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "JAVA最小内存";
            // 
            // button_java
            // 
            this.button_java.Location = new System.Drawing.Point(506, 101);
            this.button_java.Name = "button_java";
            this.button_java.Size = new System.Drawing.Size(150, 24);
            this.button_java.TabIndex = 6;
            this.button_java.Text = "选择JAVA";
            this.button_java.UseVisualStyleBackColor = true;
            this.button_java.Click += new System.EventHandler(this.Button_java_Click);
            // 
            // java_arg
            // 
            this.java_arg.Location = new System.Drawing.Point(101, 47);
            this.java_arg.Name = "java_arg";
            this.java_arg.Size = new System.Drawing.Size(516, 21);
            this.java_arg.TabIndex = 3;
            this.java_arg.Text = "-server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "JAVA启动参数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "JAVA核心位置";
            // 
            // java_local
            // 
            this.java_local.Location = new System.Drawing.Point(101, 20);
            this.java_local.Name = "java_local";
            this.java_local.Size = new System.Drawing.Size(516, 21);
            this.java_local.TabIndex = 0;
            // 
            // server_name
            // 
            this.server_name.Location = new System.Drawing.Point(74, 0);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(582, 21);
            this.server_name.TabIndex = 44;
            this.server_name.Text = "server1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "服务器名字";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_server_core);
            this.groupBox1.Controls.Add(this.server_core);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.server_arg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.server_local);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 126);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器设置";
            // 
            // button_server_core
            // 
            this.button_server_core.Location = new System.Drawing.Point(506, 101);
            this.button_server_core.Name = "button_server_core";
            this.button_server_core.Size = new System.Drawing.Size(150, 24);
            this.button_server_core.TabIndex = 6;
            this.button_server_core.Text = "选择服务器核心";
            this.button_server_core.UseVisualStyleBackColor = true;
            this.button_server_core.Click += new System.EventHandler(this.Button_server_core_Click);
            // 
            // server_core
            // 
            this.server_core.Location = new System.Drawing.Point(93, 47);
            this.server_core.Name = "server_core";
            this.server_core.Size = new System.Drawing.Size(563, 21);
            this.server_core.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务器核心名字";
            // 
            // server_arg
            // 
            this.server_arg.Location = new System.Drawing.Point(93, 74);
            this.server_arg.Name = "server_arg";
            this.server_arg.Size = new System.Drawing.Size(563, 21);
            this.server_arg.TabIndex = 3;
            this.server_arg.Text = "nogui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器启动参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器根目录";
            // 
            // server_local
            // 
            this.server_local.Location = new System.Drawing.Point(93, 20);
            this.server_local.Name = "server_local";
            this.server_local.Size = new System.Drawing.Size(563, 21);
            this.server_local.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 24);
            this.button1.TabIndex = 40;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage_serverTask
            // 
            this.tabPage_serverTask.Controls.Add(this.groupBox_41);
            this.tabPage_serverTask.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverTask.Name = "tabPage_serverTask";
            this.tabPage_serverTask.Size = new System.Drawing.Size(656, 365);
            this.tabPage_serverTask.TabIndex = 4;
            this.tabPage_serverTask.Text = "计划任务";
            this.tabPage_serverTask.UseVisualStyleBackColor = true;
            // 
            // groupBox_41
            // 
            this.groupBox_41.Controls.Add(this.listView_Task);
            this.groupBox_41.Location = new System.Drawing.Point(-4, 3);
            this.groupBox_41.Name = "groupBox_41";
            this.groupBox_41.Size = new System.Drawing.Size(664, 366);
            this.groupBox_41.TabIndex = 3;
            this.groupBox_41.TabStop = false;
            this.groupBox_41.Text = "计划任务(右键可管理任务/点我添加任务)";
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
            this.listView_Task.Size = new System.Drawing.Size(658, 346);
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
            this.columnHeader11.Width = 143;
            // 
            // tabPage_serverMod
            // 
            this.tabPage_serverMod.Controls.Add(this.groupBox_68);
            this.tabPage_serverMod.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverMod.Name = "tabPage_serverMod";
            this.tabPage_serverMod.Size = new System.Drawing.Size(656, 365);
            this.tabPage_serverMod.TabIndex = 3;
            this.tabPage_serverMod.Text = "服务器MOD";
            this.tabPage_serverMod.UseVisualStyleBackColor = true;
            // 
            // groupBox_68
            // 
            this.groupBox_68.Controls.Add(this.listView_mods);
            this.groupBox_68.Location = new System.Drawing.Point(-4, 3);
            this.groupBox_68.Name = "groupBox_68";
            this.groupBox_68.Size = new System.Drawing.Size(664, 366);
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
            this.listView_mods.Size = new System.Drawing.Size(658, 346);
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
            this.columnHeader4.Width = 203;
            // 
            // tabPage_serverPlugin
            // 
            this.tabPage_serverPlugin.Controls.Add(this.groupBox_32);
            this.tabPage_serverPlugin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverPlugin.Name = "tabPage_serverPlugin";
            this.tabPage_serverPlugin.Size = new System.Drawing.Size(656, 365);
            this.tabPage_serverPlugin.TabIndex = 2;
            this.tabPage_serverPlugin.Text = "服务器插件";
            this.tabPage_serverPlugin.UseVisualStyleBackColor = true;
            // 
            // groupBox_32
            // 
            this.groupBox_32.Controls.Add(this.listView_plugins);
            this.groupBox_32.Location = new System.Drawing.Point(-4, 3);
            this.groupBox_32.Name = "groupBox_32";
            this.groupBox_32.Size = new System.Drawing.Size(664, 366);
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
            listViewItem5});
            this.listView_plugins.Location = new System.Drawing.Point(3, 17);
            this.listView_plugins.MultiSelect = false;
            this.listView_plugins.Name = "listView_plugins";
            this.listView_plugins.Size = new System.Drawing.Size(658, 346);
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
            this.pulgin_file.Width = 289;
            // 
            // tabPage_serverSet
            // 
            this.tabPage_serverSet.Controls.Add(this.button_saveServerSet);
            this.tabPage_serverSet.Controls.Add(this.button_readServerSet);
            this.tabPage_serverSet.Controls.Add(this.config);
            this.tabPage_serverSet.Location = new System.Drawing.Point(4, 22);
            this.tabPage_serverSet.Name = "tabPage_serverSet";
            this.tabPage_serverSet.Size = new System.Drawing.Size(656, 365);
            this.tabPage_serverSet.TabIndex = 1;
            this.tabPage_serverSet.Text = "服务器配置文件";
            this.tabPage_serverSet.UseVisualStyleBackColor = true;
            // 
            // button_saveServerSet
            // 
            this.button_saveServerSet.Location = new System.Drawing.Point(506, 341);
            this.button_saveServerSet.Name = "button_saveServerSet";
            this.button_saveServerSet.Size = new System.Drawing.Size(150, 24);
            this.button_saveServerSet.TabIndex = 2;
            this.button_saveServerSet.Text = "保存当前设置";
            this.button_saveServerSet.UseVisualStyleBackColor = true;
            this.button_saveServerSet.Click += new System.EventHandler(this.button_saveServerSet_Click);
            // 
            // button_readServerSet
            // 
            this.button_readServerSet.Location = new System.Drawing.Point(350, 341);
            this.button_readServerSet.Name = "button_readServerSet";
            this.button_readServerSet.Size = new System.Drawing.Size(150, 24);
            this.button_readServerSet.TabIndex = 1;
            this.button_readServerSet.Text = "立即刷新设置";
            this.button_readServerSet.UseVisualStyleBackColor = true;
            this.button_readServerSet.Click += new System.EventHandler(this.button_readServerSet_Click);
            // 
            // config
            // 
            this.config.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.config.Location = new System.Drawing.Point(0, 0);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(656, 340);
            this.config.TabIndex = 0;
            this.config.ToolbarVisible = false;
            this.config.ViewBackColor = System.Drawing.SystemColors.ScrollBar;
            this.config.Click += new System.EventHandler(this.Config_Click);
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
            this.tabPage_serverInfo.Size = new System.Drawing.Size(656, 365);
            this.tabPage_serverInfo.TabIndex = 0;
            this.tabPage_serverInfo.Text = "服务器控制台";
            this.tabPage_serverInfo.UseVisualStyleBackColor = true;
            // 
            // button_serverStop
            // 
            this.button_serverStop.Enabled = false;
            this.button_serverStop.Location = new System.Drawing.Point(156, 341);
            this.button_serverStop.Name = "button_serverStop";
            this.button_serverStop.Size = new System.Drawing.Size(150, 24);
            this.button_serverStop.TabIndex = 2;
            this.button_serverStop.Text = "关闭服务器";
            this.button_serverStop.UseVisualStyleBackColor = true;
            this.button_serverStop.Click += new System.EventHandler(this.button_serverStop_Click);
            // 
            // button_serverClose
            // 
            this.button_serverClose.Location = new System.Drawing.Point(506, 341);
            this.button_serverClose.Name = "button_serverClose";
            this.button_serverClose.Size = new System.Drawing.Size(150, 24);
            this.button_serverClose.TabIndex = 4;
            this.button_serverClose.Text = "强制关闭服务器";
            this.button_serverClose.UseVisualStyleBackColor = true;
            this.button_serverClose.Click += new System.EventHandler(this.button_serverClose_Click);
            // 
            // button_serverRest
            // 
            this.button_serverRest.Enabled = false;
            this.button_serverRest.Location = new System.Drawing.Point(350, 341);
            this.button_serverRest.Name = "button_serverRest";
            this.button_serverRest.Size = new System.Drawing.Size(150, 24);
            this.button_serverRest.TabIndex = 3;
            this.button_serverRest.Text = "重启服务器";
            this.button_serverRest.UseVisualStyleBackColor = true;
            this.button_serverRest.Click += new System.EventHandler(this.button_serverRest_Click);
            // 
            // button_serverRun
            // 
            this.button_serverRun.Location = new System.Drawing.Point(0, 341);
            this.button_serverRun.Name = "button_serverRun";
            this.button_serverRun.Size = new System.Drawing.Size(150, 24);
            this.button_serverRun.TabIndex = 1;
            this.button_serverRun.Text = "开启服务器";
            this.button_serverRun.UseVisualStyleBackColor = true;
            this.button_serverRun.Click += new System.EventHandler(this.button_serverRun_Click);
            // 
            // groupBox_25
            // 
            this.groupBox_25.Controls.Add(this.textBox_sendServer);
            this.groupBox_25.Controls.Add(this.textBox_serverInfo);
            this.groupBox_25.Location = new System.Drawing.Point(0, 0);
            this.groupBox_25.Name = "groupBox_25";
            this.groupBox_25.Size = new System.Drawing.Size(656, 333);
            this.groupBox_25.TabIndex = 0;
            this.groupBox_25.TabStop = false;
            this.groupBox_25.Text = "服务端指令台";
            // 
            // textBox_sendServer
            // 
            this.textBox_sendServer.ForeColor = System.Drawing.Color.Gray;
            this.textBox_sendServer.Location = new System.Drawing.Point(0, 312);
            this.textBox_sendServer.Name = "textBox_sendServer";
            this.textBox_sendServer.Size = new System.Drawing.Size(656, 21);
            this.textBox_sendServer.TabIndex = 1;
            this.textBox_sendServer.Enter += new System.EventHandler(this.textBox_sendServer_Enter);
            this.textBox_sendServer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_sendServer_KeyUp);
            this.textBox_sendServer.Leave += new System.EventHandler(this.textBox_sendServer_Leave);
            // 
            // textBox_serverInfo
            // 
            this.textBox_serverInfo.Location = new System.Drawing.Point(0, 20);
            this.textBox_serverInfo.Multiline = true;
            this.textBox_serverInfo.Name = "textBox_serverInfo";
            this.textBox_serverInfo.ReadOnly = true;
            this.textBox_serverInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_serverInfo.Size = new System.Drawing.Size(656, 286);
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
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 391);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_SelectingAsync);
            // 
            // java_local_chose
            // 
            this.java_local_chose.DefaultExt = "exe";
            this.java_local_chose.Filter = "(JAVA核心java.exe)|JAVA.exe";
            this.java_local_chose.Title = "选择JAVA.exe";
            // 
            // server_local_core
            // 
            this.server_local_core.DefaultExt = "jar";
            this.server_local_core.Filter = "(服务器核心)|*.jar";
            // 
            // Window_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 387);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Minecraft_Server_QQ.Properties.Resources.Color_yr;
            this.MaximizeBox = false;
            this.Name = "Window_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器监视窗口";
            this.Load += new System.EventHandler(this.Window_Main_Load);
            this.tabPage_Server.ResumeLayout(false);
            this.tabPage_Server.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.java_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.java_min)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage_Server;
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
        public System.Windows.Forms.PropertyGrid config;
        private System.Windows.Forms.TabPage tabPage_serverInfo;
        private System.Windows.Forms.Button button_serverStop;
        private System.Windows.Forms.Button button_serverClose;
        private System.Windows.Forms.Button button_serverRest;
        private System.Windows.Forms.Button button_serverRun;
        private System.Windows.Forms.GroupBox groupBox_25;
        private System.Windows.Forms.TextBox textBox_sendServer;
        private System.Windows.Forms.TextBox textBox_serverInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox open_start;
        private System.Windows.Forms.CheckBox auto_restart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown java_max;
        private System.Windows.Forms.NumericUpDown java_min;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_java;
        private System.Windows.Forms.TextBox java_arg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox java_local;
        private System.Windows.Forms.TextBox server_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_server_core;
        private System.Windows.Forms.TextBox server_core;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox server_arg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server_local;
        private System.Windows.Forms.OpenFileDialog java_local_chose;
        private System.Windows.Forms.OpenFileDialog server_local_core;
        private System.Windows.Forms.Button button_java_auto;
    }
}

