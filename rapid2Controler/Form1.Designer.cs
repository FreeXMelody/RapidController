﻿namespace rapid2Controler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_connect = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Choosefile = new System.Windows.Forms.Button();
            this.openFileDialog_rapid = new System.Windows.Forms.OpenFileDialog();
            this.button_updata = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2_INFO = new System.Windows.Forms.Label();
            this.listBox2_fileStore = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_data = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_ioWinShow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_ConnectMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1_sysName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2_ControllerIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3_ControllerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4_sysInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5_ControllerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_controllerState = new System.Windows.Forms.Label();
            this.panel_sonForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // openFileDialog_rapid
            // 
            this.openFileDialog_rapid.FileName = "openFileDialog1";
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
            this.button_updata.Text = "     扫描IP";
            this.button_updata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updata.UseVisualStyleBackColor = false;
            this.button_updata.Click += new System.EventHandler(this.button_updata_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.AllowDrop = true;
            this.textBox_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_path.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox_path.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_path.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_path.Location = new System.Drawing.Point(84, 60);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(350, 22);
            this.textBox_path.TabIndex = 4;
            this.textBox_path.Text = "当前路径 < 准备中";
            this.textBox_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_path.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_path_DragEnter);
            this.textBox_path.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.textBox_path_GiveFeedback);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(227, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 149);
            this.listBox1.TabIndex = 6;
            this.listBox1.Visible = false;
            // 
            // label2_INFO
            // 
            this.label2_INFO.AutoSize = true;
            this.label2_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2_INFO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_INFO.ForeColor = System.Drawing.SystemColors.Window;
            this.label2_INFO.Location = new System.Drawing.Point(3, 4);
            this.label2_INFO.Name = "label2_INFO";
            this.label2_INFO.Size = new System.Drawing.Size(164, 17);
            this.label2_INFO.TabIndex = 8;
            this.label2_INFO.Text = "info <Created by:Christer>";
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
            this.panel1.Controls.Add(this.button_data);
            this.panel1.Controls.Add(this.button_min);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button_ioWinShow);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button_ConnectMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 562);
            this.panel1.TabIndex = 13;
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
            this.button_data.Location = new System.Drawing.Point(0, 325);
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
            this.button_min.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_min.Image = ((System.Drawing.Image)(resources.GetObject("button_min.Image")));
            this.button_min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_min.Location = new System.Drawing.Point(0, 481);
            this.button_min.Name = "button_min";
            this.button_min.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_min.Size = new System.Drawing.Size(172, 40);
            this.button_min.TabIndex = 12;
            this.button_min.Text = "     最小化";
            this.button_min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_min.UseVisualStyleBackColor = false;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 9);
            this.label6.TabIndex = 11;
            this.label6.Text = "Copyright © 2020 Fx.Lab. All rights reserved.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(71, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fx.Lab";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(25, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "基础数据传输";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Turquoise;
            this.panel6.Location = new System.Drawing.Point(15, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 21);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Location = new System.Drawing.Point(15, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 21);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(25, 206);
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
            this.button5.Location = new System.Drawing.Point(0, 233);
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
            this.button_ioWinShow.Location = new System.Drawing.Point(0, 279);
            this.button_ioWinShow.Name = "button_ioWinShow";
            this.button_ioWinShow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ioWinShow.Size = new System.Drawing.Size(172, 40);
            this.button_ioWinShow.TabIndex = 3;
            this.button_ioWinShow.Text = "     I/O控制";
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
            this.button3.Location = new System.Drawing.Point(0, 134);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(172, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "     文件传输";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 522);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(172, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "     退出";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button_ConnectMenu.Location = new System.Drawing.Point(0, 88);
            this.button_ConnectMenu.Name = "button_ConnectMenu";
            this.button_ConnectMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ConnectMenu.Size = new System.Drawing.Size(172, 40);
            this.button_ConnectMenu.TabIndex = 0;
            this.button_ConnectMenu.Text = "     连接";
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
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.button_updata);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_connect);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(181, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 241);
            this.panel2.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1_sysName,
            this.columnHeader2_ControllerIP,
            this.columnHeader3_ControllerName,
            this.columnHeader4_sysInfo,
            this.columnHeader5_ControllerID});
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
            this.columnHeader2_ControllerIP.Width = 87;
            // 
            // columnHeader3_ControllerName
            // 
            this.columnHeader3_ControllerName.Text = "控制器名称";
            this.columnHeader3_ControllerName.Width = 105;
            // 
            // columnHeader4_sysInfo
            // 
            this.columnHeader4_sysInfo.Text = "系统版本";
            this.columnHeader4_sysInfo.Width = 76;
            // 
            // columnHeader5_ControllerID
            // 
            this.columnHeader5_ControllerID.Text = "控制器ID";
            this.columnHeader5_ControllerID.Width = 74;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button_Choosefile);
            this.panel3.Controls.Add(this.button_update);
            this.panel3.Controls.Add(this.textBox_path);
            this.panel3.Controls.Add(this.listBox2_fileStore);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(641, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 358);
            this.panel3.TabIndex = 17;
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
            this.button7.Location = new System.Drawing.Point(280, 310);
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
            this.label7.Location = new System.Drawing.Point(143, 340);
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
            this.button6.Location = new System.Drawing.Point(280, 279);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(155, 27);
            this.button6.TabIndex = 13;
            this.button6.Text = "     导出选定文件";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_controllerState);
            this.panel4.Controls.Add(this.label2_INFO);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(172, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 44);
            this.panel4.TabIndex = 18;
            // 
            // label_controllerState
            // 
            this.label_controllerState.AutoSize = true;
            this.label_controllerState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label_controllerState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_controllerState.ForeColor = System.Drawing.SystemColors.Window;
            this.label_controllerState.Location = new System.Drawing.Point(3, 24);
            this.label_controllerState.Name = "label_controllerState";
            this.label_controllerState.Size = new System.Drawing.Size(104, 17);
            this.label_controllerState.TabIndex = 9;
            this.label_controllerState.Text = "当前控制器状态：";
            // 
            // panel_sonForm
            // 
            this.panel_sonForm.Location = new System.Drawing.Point(181, 291);
            this.panel_sonForm.Name = "panel_sonForm";
            this.panel_sonForm.Size = new System.Drawing.Size(146, 143);
            this.panel_sonForm.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 562);
            this.ControlBox = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2_fileStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ConnectMenu;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Label label5;
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
    }
}
