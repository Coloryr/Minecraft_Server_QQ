namespace Minecraft_Server_QQ
{
    partial class Add_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Server));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_server_core = new System.Windows.Forms.Button();
            this.server_core = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.server_arg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.server_local = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.server_name = new System.Windows.Forms.TextBox();
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
            this.java_local_chose = new System.Windows.Forms.OpenFileDialog();
            this.button_add = new System.Windows.Forms.Button();
            this.server_local_core = new System.Windows.Forms.OpenFileDialog();
            this.auto_restart = new System.Windows.Forms.CheckBox();
            this.open_start = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.java_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.java_min)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器设置";
            // 
            // button_server_core
            // 
            this.button_server_core.Location = new System.Drawing.Point(281, 102);
            this.button_server_core.Name = "button_server_core";
            this.button_server_core.Size = new System.Drawing.Size(121, 24);
            this.button_server_core.TabIndex = 6;
            this.button_server_core.Text = "选择服务器核心";
            this.button_server_core.UseVisualStyleBackColor = true;
            this.button_server_core.Click += new System.EventHandler(this.Button_server_core_Click);
            // 
            // server_core
            // 
            this.server_core.Location = new System.Drawing.Point(101, 47);
            this.server_core.Name = "server_core";
            this.server_core.Size = new System.Drawing.Size(301, 21);
            this.server_core.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务器核心名字";
            // 
            // server_arg
            // 
            this.server_arg.Location = new System.Drawing.Point(101, 74);
            this.server_arg.Name = "server_arg";
            this.server_arg.Size = new System.Drawing.Size(301, 21);
            this.server_arg.TabIndex = 3;
            this.server_arg.Text = "nogui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器启动参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器根目录";
            // 
            // server_local
            // 
            this.server_local.Location = new System.Drawing.Point(101, 20);
            this.server_local.Name = "server_local";
            this.server_local.Size = new System.Drawing.Size(301, 21);
            this.server_local.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "服务器名字";
            // 
            // server_name
            // 
            this.server_name.Location = new System.Drawing.Point(75, 6);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(333, 21);
            this.server_name.TabIndex = 8;
            this.server_name.Text = "server1";
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
            this.groupBox2.Location = new System.Drawing.Point(6, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JAVA设置";
            // 
            // button_java_auto
            // 
            this.button_java_auto.Location = new System.Drawing.Point(154, 103);
            this.button_java_auto.Name = "button_java_auto";
            this.button_java_auto.Size = new System.Drawing.Size(121, 24);
            this.button_java_auto.TabIndex = 13;
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
            this.button_java.Location = new System.Drawing.Point(281, 103);
            this.button_java.Name = "button_java";
            this.button_java.Size = new System.Drawing.Size(121, 24);
            this.button_java.TabIndex = 6;
            this.button_java.Text = "选择JAVA";
            this.button_java.UseVisualStyleBackColor = true;
            this.button_java.Click += new System.EventHandler(this.Button_java_Click);
            // 
            // java_arg
            // 
            this.java_arg.Location = new System.Drawing.Point(101, 47);
            this.java_arg.Name = "java_arg";
            this.java_arg.Size = new System.Drawing.Size(301, 21);
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
            this.java_local.Size = new System.Drawing.Size(301, 21);
            this.java_local.TabIndex = 0;
            // 
            // java_local_chose
            // 
            this.java_local_chose.DefaultExt = "exe";
            this.java_local_chose.Filter = "(JAVA核心java.exe)|JAVA.exe";
            this.java_local_chose.Title = "选择JAVA.exe";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(287, 310);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(121, 24);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "添加服务器";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // server_local_core
            // 
            this.server_local_core.DefaultExt = "jar";
            this.server_local_core.Filter = "(服务器核心*.jar)|.jar";
            // 
            // auto_restart
            // 
            this.auto_restart.AutoSize = true;
            this.auto_restart.Location = new System.Drawing.Point(6, 310);
            this.auto_restart.Name = "auto_restart";
            this.auto_restart.Size = new System.Drawing.Size(96, 16);
            this.auto_restart.TabIndex = 14;
            this.auto_restart.Text = "崩溃自动重启";
            this.auto_restart.UseVisualStyleBackColor = true;
            // 
            // open_start
            // 
            this.open_start.AutoSize = true;
            this.open_start.Location = new System.Drawing.Point(107, 310);
            this.open_start.Name = "open_start";
            this.open_start.Size = new System.Drawing.Size(120, 16);
            this.open_start.TabIndex = 15;
            this.open_start.Text = "开启软件自动开服";
            this.open_start.UseVisualStyleBackColor = true;
            // 
            // Add_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.open_start);
            this.Controls.Add(this.auto_restart);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.server_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加服务器";
            this.Load += new System.EventHandler(this.Add_Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.java_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.java_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Icon = Properties.Resources.Color_yr;
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server_local;
        private System.Windows.Forms.TextBox server_arg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox server_core;
        private System.Windows.Forms.Button button_server_core;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_java;
        private System.Windows.Forms.TextBox java_arg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox java_local;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown java_max;
        private System.Windows.Forms.NumericUpDown java_min;
        private System.Windows.Forms.OpenFileDialog java_local_chose;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.OpenFileDialog server_local_core;
        private System.Windows.Forms.CheckBox auto_restart;
        private System.Windows.Forms.CheckBox open_start;
        private System.Windows.Forms.Button button_java_auto;
    }
}