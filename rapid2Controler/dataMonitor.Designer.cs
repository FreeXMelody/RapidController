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
            this.label_tool = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_wobj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tool
            // 
            this.label_tool.AutoSize = true;
            this.label_tool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label_tool.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_tool.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tool.ForeColor = System.Drawing.Color.White;
            this.label_tool.Location = new System.Drawing.Point(15, 13);
            this.label_tool.Name = "label_tool";
            this.label_tool.Size = new System.Drawing.Size(88, 20);
            this.label_tool.TabIndex = 0;
            this.label_tool.Text = "       准备中...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(5, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "获取数据信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_wobj
            // 
            this.label_wobj.AutoSize = true;
            this.label_wobj.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_wobj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_wobj.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wobj.ForeColor = System.Drawing.Color.White;
            this.label_wobj.Location = new System.Drawing.Point(15, 44);
            this.label_wobj.Name = "label_wobj";
            this.label_wobj.Size = new System.Drawing.Size(88, 20);
            this.label_wobj.TabIndex = 2;
            this.label_wobj.Text = "       准备中...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label_wobj);
            this.panel1.Controls.Add(this.label_tool);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 77);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 77);
            this.panel2.TabIndex = 4;
            // 
            // dataMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "dataMonitor";
            this.Text = "数据监控";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label_tool;
        public System.Windows.Forms.Label label_wobj;
    }
}