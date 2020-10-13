using ABB.Robotics.Controllers;
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
    public partial class sf_InputOutput : Form
    {
        public static sf_InputOutput Formthis;
        public  Controller controller;
        public sf_InputOutput()
        {
            Formthis = this;
            InitializeComponent();
            controller = Form1.controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlCore.SetIOStatus(controller, textBox1.Text); ;
        }

        private void button_resetIO_Click(object sender, EventArgs e)
        {
            ctrlCore.ResetIOStatus(controller,textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = ctrlCore.ReadIOStatus(controller,textBox1.Text);
        }
    }
}
