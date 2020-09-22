using ABB.Robotics.Controllers.MotionDomain;
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
using ABB.Robotics.Controllers.RapidDomain;

namespace rapid2Controler
{
    
    public partial class dataMonitor : Form //   :Form 继承Form1
    {
        // Controller.Connect()
        Form1 Mainform;
        Tool tool1;
        WorkObject w1;
        public dataMonitor()
        {
            InitializeComponent();
            Mainform = new Form1();
            tool1 = Mainform.tool;
            w1 = Mainform.w;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tool tool = Mainform.controller.MotionSystem.ActiveMechanicalUnit.Tool; // 获取当前工具
            //WorkObject w = Mainform.controller.MotionSystem.ActiveMechanicalUnit.WorkObject; // 获取工具坐标系
            
            //// 转化为工具坐标和坐标系
            //ToolData toolData = (ToolData)tool.Data;
            //WobjData wobjData = (WobjData)w.Data;

            label_tool.Text = "当前Tool：" + tool1.Name ;
            label_wobj.Text = "工具坐标系：" + w1.Name ;
        }
    }
}
