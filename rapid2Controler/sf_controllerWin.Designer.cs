namespace rapid2Controler
{
    partial class sf_controllerWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sf_controllerWin));
            this.button_updata = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_updata
            // 
            this.button_updata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button_updata.FlatAppearance.BorderSize = 0;
            this.button_updata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updata.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button_updata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_updata.Image = ((System.Drawing.Image)(resources.GetObject("button_updata.Image")));
            this.button_updata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updata.Location = new System.Drawing.Point(25, 17);
            this.button_updata.Name = "button_updata";
            this.button_updata.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_updata.Size = new System.Drawing.Size(172, 40);
            this.button_updata.TabIndex = 4;
            this.button_updata.Text = "     重启系统";
            this.button_updata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updata.UseVisualStyleBackColor = false;
            this.button_updata.Click += new System.EventHandler(this.button_updata_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 424);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(25, 73);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(172, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "     导入模块库";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sf_controllerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_updata);
            this.Name = "sf_controllerWin";
            this.Text = "系统控制";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_updata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}