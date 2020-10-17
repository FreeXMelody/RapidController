namespace rapid2Controler
{
    partial class dataMonitor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_rapidType = new System.Windows.Forms.TextBox();
            this.textBox_symbolType = new System.Windows.Forms.TextBox();
            this.textBox_varValue = new System.Windows.Forms.TextBox();
            this.textBox_varName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_tool = new System.Windows.Forms.Label();
            this.label_wobj = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_logCount = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_rapidType);
            this.groupBox1.Controls.Add(this.textBox_symbolType);
            this.groupBox1.Controls.Add(this.textBox_varValue);
            this.groupBox1.Controls.Add(this.textBox_varName);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "访问控制器对象数据";
            // 
            // textBox_rapidType
            // 
            this.textBox_rapidType.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_rapidType.Location = new System.Drawing.Point(5, 151);
            this.textBox_rapidType.Multiline = true;
            this.textBox_rapidType.Name = "textBox_rapidType";
            this.textBox_rapidType.Size = new System.Drawing.Size(100, 13);
            this.textBox_rapidType.TabIndex = 10;
            // 
            // textBox_symbolType
            // 
            this.textBox_symbolType.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_symbolType.Location = new System.Drawing.Point(5, 132);
            this.textBox_symbolType.Multiline = true;
            this.textBox_symbolType.Name = "textBox_symbolType";
            this.textBox_symbolType.Size = new System.Drawing.Size(100, 13);
            this.textBox_symbolType.TabIndex = 9;
            // 
            // textBox_varValue
            // 
            this.textBox_varValue.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_varValue.Location = new System.Drawing.Point(5, 113);
            this.textBox_varValue.Multiline = true;
            this.textBox_varValue.Name = "textBox_varValue";
            this.textBox_varValue.Size = new System.Drawing.Size(100, 13);
            this.textBox_varValue.TabIndex = 8;
            // 
            // textBox_varName
            // 
            this.textBox_varName.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_varName.Location = new System.Drawing.Point(5, 94);
            this.textBox_varName.Multiline = true;
            this.textBox_varName.Name = "textBox_varName";
            this.textBox_varName.Size = new System.Drawing.Size(100, 13);
            this.textBox_varName.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "获取数据信息";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "模块名称：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据名称：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "获取工具信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_tool
            // 
            this.label_tool.AutoSize = true;
            this.label_tool.BackColor = System.Drawing.SystemColors.Control;
            this.label_tool.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_tool.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tool.ForeColor = System.Drawing.Color.Black;
            this.label_tool.Location = new System.Drawing.Point(6, 25);
            this.label_tool.Name = "label_tool";
            this.label_tool.Size = new System.Drawing.Size(44, 16);
            this.label_tool.TabIndex = 0;
            this.label_tool.Text = "准备中...";
            // 
            // label_wobj
            // 
            this.label_wobj.AutoEllipsis = true;
            this.label_wobj.AutoSize = true;
            this.label_wobj.BackColor = System.Drawing.SystemColors.Control;
            this.label_wobj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_wobj.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wobj.ForeColor = System.Drawing.Color.Black;
            this.label_wobj.Location = new System.Drawing.Point(3, 78);
            this.label_wobj.Name = "label_wobj";
            this.label_wobj.Size = new System.Drawing.Size(44, 16);
            this.label_wobj.TabIndex = 2;
            this.label_wobj.Text = "准备中...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_tool);
            this.groupBox2.Controls.Add(this.label_wobj);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 217);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工具信息获取";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_logCount);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.Location = new System.Drawing.Point(12, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 188);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志信息";
            // 
            // label_logCount
            // 
            this.label_logCount.AutoEllipsis = true;
            this.label_logCount.AutoSize = true;
            this.label_logCount.BackColor = System.Drawing.SystemColors.Control;
            this.label_logCount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_logCount.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_logCount.ForeColor = System.Drawing.Color.Black;
            this.label_logCount.Location = new System.Drawing.Point(416, 40);
            this.label_logCount.Name = "label_logCount";
            this.label_logCount.Size = new System.Drawing.Size(44, 16);
            this.label_logCount.TabIndex = 3;
            this.label_logCount.Text = "准备中...";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 120);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(10, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "获取日志信息";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "索引";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "标题";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "内容";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "类型";
            // 
            // dataMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "dataMonitor";
            this.Text = "数据监控";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label_tool;
        public System.Windows.Forms.Label label_wobj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_rapidType;
        private System.Windows.Forms.TextBox textBox_symbolType;
        private System.Windows.Forms.TextBox textBox_varValue;
        private System.Windows.Forms.TextBox textBox_varName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label label_logCount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}