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
        public Tool tool1 ;
        public WorkObject w1;
        public ToolData toolData;
        public  WobjData wobjData;
        public dataMonitor()
        {
            InitializeComponent();
            tool1 = Form1.tool;
            w1 = Form1.w;
            toolData = Form1.toolData;
            wobjData = Form1.wobjData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                // 转化为工具坐标和坐标系
                toolData = (ToolData)tool1.Data; // 拆箱操作
                wobjData = (WobjData)w1.Data;
                label_tool.Text = "当前Tool：" + tool1.Name + "  " + "坐标：" + toolData.ToString();
                label_wobj.Text = "工具坐标系：" + w1.Name + "  " + "工具坐标：" + wobjData.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "获取失败");
            }

         }
    }
}
