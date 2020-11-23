using ABB.Robotics.Controllers.RapidDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapid2Controler
{
    public partial class customMessageBox : Form
    {
        Form1 form1 = new Form1();
        public static Point Point;
        public customMessageBox()
        {
            InitializeComponent();
            Point = new Point(Location.X, form1.button8.Location.Y);
        }

        private void timer_opacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timer_reduceOpacity.Start();
                timer_opacity.Stop();
            }
            else
            { this.Opacity += 0.02; }
        }

        private void customMessageBox_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.MessageContent;
            // 自适应宽度 panel Size随窗体变化
            this.Size = new Size(label1.Size.Width+ button1.Size.Width + pictureBox1.Width + 7,this.Size.Height);
            pictureBox2.Size = new Size(label1.Size.Width + button1.Size.Width + pictureBox1.Width+2, pictureBox2.Size.Height);

            // 重设“关闭” 坐标  ---- 暂时不用，已设置visible为false
            // pictureBox2.Size = new Size(panel1.Size.Width+10, pictureBox2.Size.Height);
            this.Location = Form1.p2;
            timer_opacity.Interval = 20;
            timer_reduceOpacity.Interval = 20;
            timer_opacity.Start();
            timer_location.Interval = 20;
            timer_location.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //this.Close();
        }

        private void timer_location_Tick(object sender, EventArgs e)
        {
            if (Location == Point)
            {
                timer_location.Stop();
            }
            else { this.Location = new Point(Location.X, Location.Y + 1); }

        }

        private void timer_reduceOpacity_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Dispose();
                this.Close();
            }
            else { this.Opacity -= 0.02; }
        }
    }
}
