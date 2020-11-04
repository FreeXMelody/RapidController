namespace rapid2Controler
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog_rapid = new System.Windows.Forms.OpenFileDialog();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label2_INFO = new System.Windows.Forms.Label();
            this.listBox2_fileStore = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button_checkProgramm = new System.Windows.Forms.Button();
            this.button_data = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_ioWinShow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_ConnectMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_OpenCfgFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1_sysName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2_ControllerIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3_ControllerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4_sysInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5_ControllerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6_Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_updata = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button_resetPoint = new System.Windows.Forms.Button();
            this.button_loadModule = new System.Windows.Forms.Button();
            this.checkBox_InsertVar = new System.Windows.Forms.CheckBox();
            this.checkBox_storePath = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fresh = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.listBox_insertedCodelist = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button_Choosefile = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label_controllerState = new System.Windows.Forms.Label();
            this.panel_sonForm = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_rapid
            // 
            this.openFileDialog_rapid.FileName = "openFileDialog1";
            // 
            // textBox_path
            // 
            this.textBox_path.AllowDrop = true;
            this.textBox_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_path.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox_path.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_path.ForeColor = System.Drawing.Color.Teal;
            this.textBox_path.Location = new System.Drawing.Point(84, 60);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(350, 22);
            this.textBox_path.TabIndex = 4;
            this.textBox_path.Text = "当前路径 < 准备中";
            this.textBox_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_path.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_path_DragEnter);
            // 
            // label2_INFO
            // 
            this.label2_INFO.AutoSize = true;
            this.label2_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2_INFO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_INFO.ForeColor = System.Drawing.SystemColors.Window;
            this.label2_INFO.Location = new System.Drawing.Point(3, 4);
            this.label2_INFO.Name = "label2_INFO";
            this.label2_INFO.Size = new System.Drawing.Size(277, 17);
            this.label2_INFO.TabIndex = 8;
            this.label2_INFO.Text = "info <Created by:Christer \"啊~是文先森，wsl\">";
            // 
            // listBox2_fileStore
            // 
            this.listBox2_fileStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.listBox2_fileStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2_fileStore.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox2_fileStore.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox2_fileStore.FormattingEnabled = true;
            this.listBox2_fileStore.ItemHeight = 20;
            this.listBox2_fileStore.Location = new System.Drawing.Point(84, 134);
            this.listBox2_fileStore.Name = "listBox2_fileStore";
            this.listBox2_fileStore.Size = new System.Drawing.Size(350, 140);
            this.listBox2_fileStore.TabIndex = 10;
            this.listBox2_fileStore.SelectedIndexChanged += new System.EventHandler(this.listBox2_fileStore_SelectedIndexChanged);
            this.listBox2_fileStore.DoubleClick += new System.EventHandler(this.listBox2_fileStore_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "扫描HOME目录";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(262, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "删除选定文件";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button_checkProgramm);
            this.panel1.Controls.Add(this.button_data);
            this.panel1.Controls.Add(this.button_min);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button_ioWinShow);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_ConnectMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 562);
            this.panel1.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 430);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(172, 26);
            this.button9.TabIndex = 22;
            this.button9.Text = "       最小化到托盘";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button_checkProgramm
            // 
            this.button_checkProgramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button_checkProgramm.FlatAppearance.BorderSize = 0;
            this.button_checkProgramm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkProgramm.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.button_checkProgramm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_checkProgramm.Image = ((System.Drawing.Image)(resources.GetObject("button_checkProgramm.Image")));
            this.button_checkProgramm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_checkProgramm.Location = new System.Drawing.Point(12, 359);
            this.button_checkProgramm.Name = "button_checkProgramm";
            this.button_checkProgramm.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_checkProgramm.Size = new System.Drawing.Size(143, 31);
            this.button_checkProgramm.TabIndex = 14;
            this.button_checkProgramm.Text = "     快速检查程序";
            this.button_checkProgramm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_checkProgramm.UseVisualStyleBackColor = false;
            this.button_checkProgramm.Click += new System.EventHandler(this.button_checkProgramm_Click);
            // 
            // button_data
            // 
            this.button_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button_data.FlatAppearance.BorderSize = 0;
            this.button_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_data.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_data.Image = ((System.Drawing.Image)(resources.GetObject("button_data.Image")));
            this.button_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_data.Location = new System.Drawing.Point(0, 315);
            this.button_data.Name = "button_data";
            this.button_data.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_data.Size = new System.Drawing.Size(172, 40);
            this.button_data.TabIndex = 13;
            this.button_data.Text = "     数据监控";
            this.button_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_data.UseVisualStyleBackColor = false;
            this.button_data.Click += new System.EventHandler(this.button_data_Click);
            // 
            // button_min
            // 
            this.button_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button_min.FlatAppearance.BorderSize = 0;
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_min.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_min.Image = ((System.Drawing.Image)(resources.GetObject("button_min.Image")));
            this.button_min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_min.Location = new System.Drawing.Point(0, 398);
            this.button_min.Name = "button_min";
            this.button_min.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_min.Size = new System.Drawing.Size(172, 26);
            this.button_min.TabIndex = 12;
            this.button_min.Text = "       最小化";
            this.button_min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_min.UseVisualStyleBackColor = false;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 5.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(61, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Copyright © 2020 Fx.Lab. \r\n     All rights reserved.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据传输与测验";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(17, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 21);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(17, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 21);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(25, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "其他控制";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 223);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(172, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "     系统控制";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_ioWinShow
            // 
            this.button_ioWinShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button_ioWinShow.FlatAppearance.BorderSize = 0;
            this.button_ioWinShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ioWinShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ioWinShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ioWinShow.Image = ((System.Drawing.Image)(resources.GetObject("button_ioWinShow.Image")));
            this.button_ioWinShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ioWinShow.Location = new System.Drawing.Point(0, 269);
            this.button_ioWinShow.Name = "button_ioWinShow";
            this.button_ioWinShow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ioWinShow.Size = new System.Drawing.Size(172, 40);
            this.button_ioWinShow.TabIndex = 3;
            this.button_ioWinShow.Text = "     IO / Socket";
            this.button_ioWinShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ioWinShow.UseVisualStyleBackColor = false;
            this.button_ioWinShow.Click += new System.EventHandler(this.button_ioWinShow_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 147);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(172, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "     文件管理";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.Location = new System.Drawing.Point(0, 522);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(172, 40);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "     退出";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_ConnectMenu
            // 
            this.button_ConnectMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button_ConnectMenu.FlatAppearance.BorderSize = 0;
            this.button_ConnectMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConnectMenu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ConnectMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ConnectMenu.Image = ((System.Drawing.Image)(resources.GetObject("button_ConnectMenu.Image")));
            this.button_ConnectMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ConnectMenu.Location = new System.Drawing.Point(0, 101);
            this.button_ConnectMenu.Name = "button_ConnectMenu";
            this.button_ConnectMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ConnectMenu.Size = new System.Drawing.Size(172, 40);
            this.button_ConnectMenu.TabIndex = 0;
            this.button_ConnectMenu.Text = "     初始 /. 连接";
            this.button_ConnectMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ConnectMenu.UseVisualStyleBackColor = false;
            this.button_ConnectMenu.Click += new System.EventHandler(this.button_ConnectMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(180, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "IP扫描结果：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_OpenCfgFile);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.button_updata);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_connect);
            this.panel2.Location = new System.Drawing.Point(181, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 274);
            this.panel2.TabIndex = 16;
            // 
            // label_OpenCfgFile
            // 
            this.label_OpenCfgFile.AutoSize = true;
            this.label_OpenCfgFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label_OpenCfgFile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_OpenCfgFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label_OpenCfgFile.Location = new System.Drawing.Point(9, 234);
            this.label_OpenCfgFile.Name = "label_OpenCfgFile";
            this.label_OpenCfgFile.Size = new System.Drawing.Size(80, 17);
            this.label_OpenCfgFile.TabIndex = 22;
            this.label_OpenCfgFile.Text = "打开配置文件";
            this.label_OpenCfgFile.Click += new System.EventHandler(this.label_OpenCfgFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "! 选中系统名称以进行连接";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(10, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 20);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "下次启动时自动连接";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1_sysName,
            this.columnHeader2_ControllerIP,
            this.columnHeader3_ControllerName,
            this.columnHeader4_sysInfo,
            this.columnHeader5_ControllerID,
            this.columnHeader6_Port});
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(9, 82);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 143);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1_sysName
            // 
            this.columnHeader1_sysName.Text = "系统名称";
            this.columnHeader1_sysName.Width = 96;
            // 
            // columnHeader2_ControllerIP
            // 
            this.columnHeader2_ControllerIP.Text = "IP";
            this.columnHeader2_ControllerIP.Width = 62;
            // 
            // columnHeader3_ControllerName
            // 
            this.columnHeader3_ControllerName.Text = "控制器名称";
            this.columnHeader3_ControllerName.Width = 75;
            // 
            // columnHeader4_sysInfo
            // 
            this.columnHeader4_sysInfo.Text = "系统版本";
            this.columnHeader4_sysInfo.Width = 71;
            // 
            // columnHeader5_ControllerID
            // 
            this.columnHeader5_ControllerID.Text = "控制器ID";
            this.columnHeader5_ControllerID.Width = 70;
            // 
            // columnHeader6_Port
            // 
            this.columnHeader6_Port.Text = "端口";
            // 
            // button_updata
            // 
            this.button_updata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_updata.FlatAppearance.BorderSize = 0;
            this.button_updata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updata.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button_updata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_updata.Image = ((System.Drawing.Image)(resources.GetObject("button_updata.Image")));
            this.button_updata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updata.Location = new System.Drawing.Point(47, 5);
            this.button_updata.Name = "button_updata";
            this.button_updata.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_updata.Size = new System.Drawing.Size(172, 40);
            this.button_updata.TabIndex = 3;
            this.button_updata.Text = "     扫描";
            this.button_updata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updata.UseVisualStyleBackColor = false;
            this.button_updata.Click += new System.EventHandler(this.button_updata_Click);
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_connect.FlatAppearance.BorderSize = 0;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button_connect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_connect.Image = ((System.Drawing.Image)(resources.GetObject("button_connect.Image")));
            this.button_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_connect.Location = new System.Drawing.Point(225, 5);
            this.button_connect.Name = "button_connect";
            this.button_connect.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_connect.Size = new System.Drawing.Size(172, 40);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "     连接\r\n";
            this.button_connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button_resetPoint);
            this.panel3.Controls.Add(this.button_loadModule);
            this.panel3.Controls.Add(this.checkBox_InsertVar);
            this.panel3.Controls.Add(this.checkBox_storePath);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button_Choosefile);
            this.panel3.Controls.Add(this.button_update);
            this.panel3.Controls.Add(this.textBox_path);
            this.panel3.Controls.Add(this.listBox2_fileStore);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(641, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 487);
            this.panel3.TabIndex = 17;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(3, 62);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 22);
            this.button12.TabIndex = 23;
            this.button12.Text = "plcIO表";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(3, 38);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 22);
            this.button11.TabIndex = 22;
            this.button11.Text = "调用例图";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(3, 14);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 22);
            this.button10.TabIndex = 21;
            this.button10.Text = "IO表";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button_resetPoint
            // 
            this.button_resetPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button_resetPoint.FlatAppearance.BorderSize = 0;
            this.button_resetPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetPoint.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button_resetPoint.ForeColor = System.Drawing.Color.White;
            this.button_resetPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_resetPoint.Location = new System.Drawing.Point(3, 339);
            this.button_resetPoint.Name = "button_resetPoint";
            this.button_resetPoint.Size = new System.Drawing.Size(91, 22);
            this.button_resetPoint.TabIndex = 20;
            this.button_resetPoint.Text = "复位程序指针";
            this.button_resetPoint.UseVisualStyleBackColor = false;
            this.button_resetPoint.Click += new System.EventHandler(this.button_resetPoint_Click);
            // 
            // button_loadModule
            // 
            this.button_loadModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button_loadModule.FlatAppearance.BorderSize = 0;
            this.button_loadModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_loadModule.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button_loadModule.ForeColor = System.Drawing.Color.White;
            this.button_loadModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_loadModule.Location = new System.Drawing.Point(3, 363);
            this.button_loadModule.Name = "button_loadModule";
            this.button_loadModule.Size = new System.Drawing.Size(91, 22);
            this.button_loadModule.TabIndex = 19;
            this.button_loadModule.Text = "载入所选模块";
            this.button_loadModule.UseVisualStyleBackColor = false;
            this.button_loadModule.Click += new System.EventHandler(this.button_loadModule_Click);
            // 
            // checkBox_InsertVar
            // 
            this.checkBox_InsertVar.AutoSize = true;
            this.checkBox_InsertVar.Checked = true;
            this.checkBox_InsertVar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_InsertVar.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_InsertVar.Location = new System.Drawing.Point(7, 389);
            this.checkBox_InsertVar.Name = "checkBox_InsertVar";
            this.checkBox_InsertVar.Size = new System.Drawing.Size(87, 20);
            this.checkBox_InsertVar.TabIndex = 18;
            this.checkBox_InsertVar.Text = "允许插入变量";
            this.checkBox_InsertVar.UseVisualStyleBackColor = true;
            // 
            // checkBox_storePath
            // 
            this.checkBox_storePath.AutoSize = true;
            this.checkBox_storePath.Checked = true;
            this.checkBox_storePath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_storePath.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_storePath.Location = new System.Drawing.Point(7, 415);
            this.checkBox_storePath.Name = "checkBox_storePath";
            this.checkBox_storePath.Size = new System.Drawing.Size(87, 20);
            this.checkBox_storePath.TabIndex = 17;
            this.checkBox_storePath.Text = "保留上传路径";
            this.checkBox_storePath.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fresh);
            this.groupBox1.Controls.Add(this.button_insert);
            this.groupBox1.Controls.Add(this.listBox_insertedCodelist);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(133, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 107);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "插入代码段";
            // 
            // button_fresh
            // 
            this.button_fresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_fresh.FlatAppearance.BorderSize = 0;
            this.button_fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fresh.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_fresh.ForeColor = System.Drawing.Color.White;
            this.button_fresh.Location = new System.Drawing.Point(199, 24);
            this.button_fresh.Name = "button_fresh";
            this.button_fresh.Size = new System.Drawing.Size(47, 21);
            this.button_fresh.TabIndex = 18;
            this.button_fresh.Text = "刷新";
            this.button_fresh.UseVisualStyleBackColor = false;
            this.button_fresh.Click += new System.EventHandler(this.button_fresh_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_insert.FlatAppearance.BorderSize = 0;
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_insert.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_insert.ForeColor = System.Drawing.Color.White;
            this.button_insert.Location = new System.Drawing.Point(199, 51);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(47, 21);
            this.button_insert.TabIndex = 17;
            this.button_insert.Text = "插入";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // listBox_insertedCodelist
            // 
            this.listBox_insertedCodelist.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_insertedCodelist.FormattingEnabled = true;
            this.listBox_insertedCodelist.ItemHeight = 17;
            this.listBox_insertedCodelist.Location = new System.Drawing.Point(7, 24);
            this.listBox_insertedCodelist.Name = "listBox_insertedCodelist";
            this.listBox_insertedCodelist.Size = new System.Drawing.Size(188, 72);
            this.listBox_insertedCodelist.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(101, 280);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(155, 27);
            this.button7.TabIndex = 15;
            this.button7.Text = "    打开文件夹";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "! 文件在控制器内被更改时需另存为再执行导出操作。";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(262, 279);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(155, 27);
            this.button6.TabIndex = 13;
            this.button6.Text = "     导出选定文件";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_Choosefile
            // 
            this.button_Choosefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Choosefile.FlatAppearance.BorderSize = 0;
            this.button_Choosefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Choosefile.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Choosefile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Choosefile.Image = ((System.Drawing.Image)(resources.GetObject("button_Choosefile.Image")));
            this.button_Choosefile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Choosefile.Location = new System.Drawing.Point(84, 14);
            this.button_Choosefile.Name = "button_Choosefile";
            this.button_Choosefile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_Choosefile.Size = new System.Drawing.Size(172, 40);
            this.button_Choosefile.TabIndex = 2;
            this.button_Choosefile.Text = "     选择文件";
            this.button_Choosefile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Choosefile.UseVisualStyleBackColor = false;
            this.button_Choosefile.Click += new System.EventHandler(this.button_Choosefile_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.Image = ((System.Drawing.Image)(resources.GetObject("button_update.Image")));
            this.button_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_update.Location = new System.Drawing.Point(262, 14);
            this.button_update.Name = "button_update";
            this.button_update.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_update.Size = new System.Drawing.Size(172, 40);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "     上传";
            this.button_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.label_controllerState);
            this.panel4.Controls.Add(this.label2_INFO);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(172, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 44);
            this.panel4.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(234, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "show";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // label_controllerState
            // 
            this.label_controllerState.AutoSize = true;
            this.label_controllerState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label_controllerState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_controllerState.ForeColor = System.Drawing.SystemColors.Window;
            this.label_controllerState.Location = new System.Drawing.Point(3, 24);
            this.label_controllerState.Name = "label_controllerState";
            this.label_controllerState.Size = new System.Drawing.Size(114, 17);
            this.label_controllerState.TabIndex = 9;
            this.label_controllerState.Text = " <当前控制器状态>";
            this.label_controllerState.Click += new System.EventHandler(this.label_controllerState_Click);
            // 
            // panel_sonForm
            // 
            this.panel_sonForm.Location = new System.Drawing.Point(181, 291);
            this.panel_sonForm.Name = "panel_sonForm";
            this.panel_sonForm.Size = new System.Drawing.Size(146, 143);
            this.panel_sonForm.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RapidController";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 562);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel_sonForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RobotController";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Choosefile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_rapid;
        private System.Windows.Forms.Button button_updata;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.ListBox listBox2_fileStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ConnectMenu;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_ioWinShow;
        private System.Windows.Forms.Panel panel_sonForm;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label2_INFO;
        private System.Windows.Forms.Button button_data;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1_sysName;
        private System.Windows.Forms.ColumnHeader columnHeader2_ControllerIP;
        private System.Windows.Forms.ColumnHeader columnHeader3_ControllerName;
        private System.Windows.Forms.ColumnHeader columnHeader4_sysInfo;
        private System.Windows.Forms.ColumnHeader columnHeader5_ControllerID;
        public System.Windows.Forms.Label label_controllerState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_insertedCodelist;
        private System.Windows.Forms.Button button_fresh;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.CheckBox checkBox_storePath;
        private System.Windows.Forms.CheckBox checkBox_InsertVar;
        private System.Windows.Forms.ColumnHeader columnHeader6_Port;
        private System.Windows.Forms.Button button_checkProgramm;
        private System.Windows.Forms.Button button_loadModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_resetPoint;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label_OpenCfgFile;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

