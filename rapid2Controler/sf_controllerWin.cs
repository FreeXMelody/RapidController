using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.EventLogDomain;
using ABB.Robotics.Controllers.FileSystemDomain;
namespace rapid2Controler
{
    public partial class sf_controllerWin : Form
    {
        public Form1 form1;
        public static Controller controllerA ;
        public sf_controllerWin()
        {

            InitializeComponent();
            controllerA = Form1.controller;
        }

        private void button_updata_Click(object sender, EventArgs e)    // 重启控制器
        {

                try {
                if (MessageBox.Show("确认重启？此操作不可撤销····", "重启提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controllerA.Restart(ControllerStartMode.Warm);
                    form1.label2_INFO.Text = "重启控制器完毕。";
                    form1.setInfoColor(Color.FromArgb(153, 204, 102), Color.FromArgb(248, 248, 255));
                }
            }
            catch (System.Exception ex)
                { MessageBox.Show(ex.Message + "发生异常"); }
            //try { form1.controller.Restart(0); } catch (System.NullReferenceException ex) { MessageBox.Show(ex.Message + "重启失败","发生异常",MessageBoxButtons.OK,MessageBoxIcon.Error); } }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DirectoryName = "/ModuleLib";
            string localFileLibPath = Application.StartupPath + "/" + DirectoryName+ "/";//  加反斜杠

            string homePath = controllerA.FileSystem.RemoteDirectory;
            // Console.WriteLine(root);
            // path：/hd0a/120-504462/HOME
            if (false == DirectoriesControl.CheckDirectoryExists(DirectoryName, 0))
            {
                controllerA.FileSystem.CreateDirectory(DirectoryName);
                MessageBox.Show("检查到目录不存在，当前已初始化完毕，重新执行以开始····");
            }
            else 
            { 
                


            }


       }

       

    }
}
