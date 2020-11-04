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
    public partial class dataMonitor : Form
    {
        public Tool tool1 ;
        static Form1 Form1 = new Form1();
        static Controller controller;
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
            controller = Form1.controller;
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

        private void button2_Click(object sender, EventArgs e)
        {
            RapidData aData = controller.Rapid.GetTask("T_ROB1").GetModule(textBox2.Text).GetRapidData(textBox1.Text);
            textBox_rapidType.Text = aData.RapidType;
            textBox_symbolType.Text = aData.Symbol.ToString();
            textBox_varName.Text = aData.Name;
            textBox_varValue.Text = aData.StringValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 读取日志信息
            EventLogCategory[] _cats = controller.EventLog.GetCategories();
            listView1.Items.Clear();
            ListViewItem _item;
            foreach (EventLogCategory _cat in _cats)
            {
                foreach (EventLogMessage _msg in _cat.Messages)
                {
                    _item = new ListViewItem(_msg.SequenceNumber.ToString());
                    _item.SubItems.Add(_msg.Title); 
                    _item.SubItems.Add(_msg.Body);
                    _item.SubItems.Add(_msg.Type.ToString()) ;
                    this.listView1.Items.Add(_item);
                }
            }
        }
    }
}
