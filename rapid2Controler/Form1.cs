using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;   
using ABB.Robotics.Controllers.EventLogDomain;
using ABB.Robotics.Controllers.FileSystemDomain;
using ABB.Robotics.Controllers.MotionDomain;
using ABB.Robotics.Controllers.RapidDomain;
using rapid2Controler.functionClass;

namespace rapid2Controler
{

    public partial class Form1 : Form
    {
        public NetworkScanner scanner;
        public static Controller controller;
        public ControllerInfoCollection controllers;
        public string fileName = "";
        public bool activeForm = false;
        public Color defaultBackColor = Color.FromArgb(51, 153, 153);
        // 默认文字颜色 defaultforeColor
        public Color defaultforeColor = Color.FromName("Window");
        public Color Warning_BackColor = Color.FromArgb(205, 38, 38);
        public Color Prompt_BackColor = Color.FromArgb(30, 144, 255);
        public ControllerInfo controllerInfos1;
        public int ALLdg;
        public static Tool tool; // 获取当前工具
        public static WorkObject w; // 获取工具坐标系
        // 转化为工具坐标和坐标系
        public static ToolData toolData;
        public static WobjData wobjData;
        // 插入代码段
        public string InsertedCodePath = Application.StartupPath + @"\InsertedCode\";
        // 记录sonform_text
        public string sonformText;
        // get task
        public ABB.Robotics.Controllers.RapidDomain.Task tRob1;
        public ABB.Robotics.Controllers.RapidDomain.Task[] aTask;
        // myMessageBox location / text
        public static Point p2;
        public static string MessageContent;
        // config.ini Read & Write
        string cfgPath = Application.StartupPath + "/config.ini";
        public Form1()
        {
            InitializeComponent();
            Checkcfg_g();
            // init form layout
            this.Size = new Size(712, 543);
            panel2.Visible = false;
            panel3.Visible = false;
        }

        /// <summary>
        /// 全局配置项检查
        /// </summary>
        public void Checkcfg_g()
        {
            // 显示[快速检查程序] 
            string checkRapid = config.Read("cfgInit","ShowCheckRapid","0",cfgPath);
            // 自动连接配置项
            string a = config.Read("cfgInit", "AutoConnect", "0", cfgPath);
            // 显示[ 复位程序指针]
            string ShowPointer = config.Read("cfgInit", "ShowResetPointer","0",cfgPath);
            // 显示表单 ShowAllSheets
            string ShowSheets = config.Read("cfgInit", "ShowAllSheets", "0", cfgPath);
            if (a == "1")
            {
                checkBox1.Checked = true;
                CheckAutoConnectCfg();
            }
                if (checkRapid == "1")
            {
                button_checkProgramm.Visible = true;
            }
            else button_checkProgramm.Visible = false;
            if (ShowPointer == "1")
            {
                button_resetPoint.Visible = true;
            }
            else button_resetPoint.Visible = false;

        }
        /// <summary>
        /// 检查是否存在已经应用自动连接的配置项
        /// </summary>
        public void CheckAutoConnectCfg()
        {
                try
                {
                    if (controller == null)
                    {
                        AutoConnect();
                    }
                    else { }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void AutoConnect()
        {
            scanner = new NetworkScanner();
            scanner.Scan();
            controllers = scanner.Controllers;
            string id = config.Read("ID","RobID","0",cfgPath);
            Guid a = Guid.Parse(id);
            foreach (ControllerInfo info in controllers)
            {
                if (info.SystemId == a)
                {
                    controller = Controller.Connect(info.SystemId, ConnectionType.Standalone);
                    controller.Logon(UserInfo.DefaultUser);
                    Text = "当前已自动连接 ID：" + id + "    IP:" + info.IPAddress.ToString() + "    Port:"+info.WebServicesPort.ToString();
                    label2_INFO.Text = "已连接。";
                    setInfoColor();
                    ShowNewMessage("ヽ(✿ﾟ▽ﾟ)ノ 成功连接到示教器啦：" + id);
                    button_connect.Text = "     断开";
                }
                else { MessageBox.Show("(ノへ￣、) 未扫描到控制器或控制器ID不存在，请检查配置文件！", "自动连接错误");}
            }
        }

        private void button_Choosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = ".mod文件(*.mod)|*.mod";
            fileDialog.ValidateNames = true;
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = fileDialog.FileName;
                fileName = fileDialog.SafeFileName; // 仅文件名不含路径
                this.Text = "当前文件名：" + fileDialog.SafeFileName;
                textBox_path.Text = textBox_path.Text.Replace("\\", "//");
            }
            else { this.Text = textBox_path.Text = ""; }
        }

        private void button_update_Click(object sender, EventArgs e)    // 上传文件
        {
            // 更新文件 & 将mod文件上传到控制器
            if (textBox_path.Text == "")
            { MessageBox.Show("文件为空，你是不是还没有选择上传文件呢？"); return; }
            try
            {
                if (controller.FileSystem.FileExists(fileName) == true)
                {
                    controller.FileSystem.PutFile(textBox_path.Text, true);
                    button1_Click(null, null); // 上传后刷新列表
                    label2_INFO.Text = "目录已存在同名文件，已覆盖上传至控制器。" +  "---" + $"文件列表已刷新，共发现文件 {ALLdg} 个";
                    setInfoColor(Color.FromArgb(30, 144, 255), Color.FromArgb(248, 248, 255));
                    // 是否保留路径
                    if (checkBox_storePath.Checked == true) { }
                    else { textBox_path.Text = "当前路径 < 准备中"; }
                }
                else { 
                    controller.FileSystem.PutFile(textBox_path.Text); 
                    button1_Click(null, null);
                    label2_INFO.Text = ("已上传至控制器，" + controller.FileSystem.GetRemotePath(fileName) +"目录下"  +  "---" + $"文件列表已刷新，共发现文件 {ALLdg} 个");
                    ShowNewMessage("已上传至控制器，" + controller.FileSystem.GetRemotePath(fileName) + "目录下");
                    setInfoColor(Color.FromArgb(30, 144, 255), Color.FromArgb(248, 248, 255));

                    if (checkBox_storePath.Checked == true) { }
                    else { textBox_path.Text = "当前路径 < 准备中"; }
                }
            }
            catch (InvalidOperationException ex) { label2_INFO.Text = (ex.Message + "上传失败"); setInfoColor(Color.FromArgb(205, 38, 38), Color.FromArgb(248, 248, 255)); }
            catch (Exception ex) { label2_INFO.Text = (ex.Message + "上传失败"); setInfoColor(Color.FromArgb(205, 38, 38), Color.FromArgb(248, 248, 255)); }
        }
       
        /// <summary>
        /// 扫描控制器
        /// </summary>
        public void scanNetwork()
        {
            scanner = new NetworkScanner();
            scanner.Scan();
            controllers = scanner.Controllers;
            // listBox1.Items.Clear();
            ListViewItem listViewItem1;
            listView1.Items.Clear();
            foreach (ControllerInfo info in controllers)
            {
                listViewItem1 = new ListViewItem(info.SystemName);
                // INDEX: SysName/ IP / ControllerName / SysInfo  / ID / Port
               // listViewItem1.Text = (info.SystemName); // 第一列
                listViewItem1.SubItems.Add(info.IPAddress.ToString());
                listViewItem1.SubItems.Add(info.ControllerName);
                listViewItem1.SubItems.Add(info.Version.ToString());
                listViewItem1.SubItems.Add(info.SystemId.ToString());
                listViewItem1.SubItems.Add(info.WebServicesPort.ToString());
                listView1.Items.Add(listViewItem1);
            }
        }
        public void connectController()
        {
            foreach (ControllerInfo info in controllers)
            {
                if (controller != null) // 登出
                {
                    controller.Logoff();
                    label2_INFO.Text = "已断开连接。";
                    Text = "已断开连接....";
                    setInfoColor();
                    controller.Dispose(); // 释放资源
                    controller = null;
                    button_connect.Text = "     连接";
                }
                else // 登入
                {
                    Guid a = new Guid();
                    a = Guid.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                    controller = Controller.Connect(a, ConnectionType.Standalone);
                    controller.Logon(UserInfo.DefaultUser);
                    Text = "当前已连接：" + listView1.SelectedItems[0].Text;
                    label2_INFO.Text = "已连接。";
                    setInfoColor();
                    ShowNewMessage("已连接到控制器：" + listView1.SelectedItems[0].Text);
                    button_connect.Text = "     断开";
                }
            }
        }
        public void button_connect_Click(object sender, EventArgs e)
        {
            // 连接到示教器
            connectController();
        }

        private void button_updata_Click(object sender, EventArgs e)
        {
            scanNetwork();
            label1.Text = " IP扫描结果：" + listView1.Items.Count.ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2_fileStore.Items.Clear(); // 清空，重置
            ControllerFileSystemInfo[] Anarray; 
            Anarray = controller.FileSystem.GetFilesAndDirectories("*"); // 匹配所有文件及目录
            for (int i = 0; i < Anarray.Length; i++)
            {
                listBox2_fileStore.Items.Add(Anarray[i].FullName.Split('/').Last()); 
            }
            ALLdg = listBox2_fileStore.Items.Count;
            label2_INFO.Text = $"扫描完毕，共发现文件{ALLdg}个"; 
            setInfoColor(Color.FromArgb(30,144,255), Color.FromArgb(248, 248, 255));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectFileName = listBox2_fileStore.SelectedItem.ToString();
            try
            {
                if (true == DirectoriesControl.IsDirectory(selectFileName))
                { controller.FileSystem.RemoveDirectory(selectFileName); }
                else { controller.FileSystem.RemoveFile(selectFileName);
            }  // 控制器绝对路径 listBox2_fileStore.SelectedItem.ToString()
                label2_INFO.Text = "文件已删除，其文件(夹)名：" + selectFileName + "---" + $"文件列表已刷新";
                this.button1_Click(null, null); // 刷新
                setInfoColor(Color.FromArgb(30, 144, 255), Color.FromArgb(248, 248, 255));
            }
            catch (NullReferenceException ex) { label2_INFO.Text = (ex.Message + "....删除失败！"); setInfoColor(Color.FromArgb(205,38,38), Color.FromArgb(248, 248, 255)); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗,你是不是手滑了？（*゜ー゜*）", "我要关闭！", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        // panel 显示子窗口 
        public void ShowForm(Form formA, Panel panelA)
        {
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel2.Visible = false;
                panel3.Visible = false;

                panel_sonForm.Visible = true;

                panelA.Size = new Size(524, 462);
                panelA.Location = new Point(172, 0);
                panelA.Controls.Clear(); 
                formA.TopLevel = false;
                formA.FormBorderStyle = FormBorderStyle.None;
                formA.Parent = panelA;
                formA.Dock = DockStyle.Fill;
                panelA.Controls.Add(formA);
                formA.Show();
        }

        private void button_ConnectMenu_Click(object sender, EventArgs e)
        {
            new sf_InputOutput().Close();
            panel3.Visible = false;
            panel2.Enabled = true;
            panel2.Visible = true;
            label2_INFO.Text = "[连接]窗口已显示，请确保 [ 其他控制 ] 窗口已关闭。";
            checkVisibleSonForm();
                setInfoColor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new sf_InputOutput().Close();
            panel2.Visible = false;
            panel3.Location = panel2.Location;
            panel3.Enabled = true;
            panel3.Visible = true;
            label2_INFO.Text = "[文件传输]窗口已显示，请确保 [ 其他控制 ] 窗口已关闭。";
            checkVisibleSonForm();
           setInfoColor();
        }

        private void listBox2_fileStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2_INFO.Text = "当前选中文件(夹)："+listBox2_fileStore.SelectedItem.ToString();
                setInfoColor();
        }

        private void button_ioWinShow_Click(object sender, EventArgs e)
        {
            activeWindow(new sf_InputOutput()); 
        }

        /// <summary>
        /// 激活子窗口
        /// </summary>
        /// <param name="form">form对象</param>
        public void activeWindow(Form form)
        {
            panel2.Visible = false;
            panel3.Visible = false;

            if (activeForm != false)
            {
                form.Close();
                label2_INFO.Text = "已关闭窗口："+form.Text;
                setInfoColor();
                panel_sonForm.Visible = false;
                activeForm = false;

            }
            else
            {
                ShowForm(form, panel_sonForm);
                label2_INFO.Text = "当前窗口已加载："+ form.Text;
                setInfoColor();
                activeForm = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activeWindow(new sf_controllerWin());
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string currPath = Application.StartupPath;
            string subPath = currPath + "/CodeExported/";
            if (false == System.IO.Directory.Exists(subPath))
            {
                //不存在则创建文件夹
                System.IO.Directory.CreateDirectory(subPath);
            }

            string localDir = controller.FileSystem.LocalDirectory + @"\CodeExported\"+ listBox2_fileStore.SelectedItem.ToString().Split('/').Last();

            // 导出文件
            try {
                controller.FileSystem.GetFile(listBox2_fileStore.SelectedItem.ToString(),localDir, true); 
                label2_INFO.Text = "文件导出成功，文件名为："+ listBox2_fileStore.SelectedItem.ToString().Split('/').Last() +"  目录："+localDir;
                setInfoColor(Color.FromArgb(153, 204, 102), Color.FromArgb(248, 248, 255));
            }
            catch (System.InvalidOperationException) { label2_INFO.Text = ("文件为只读文件，覆写失败！"); setInfoColor(Color.FromArgb(205,38,38), Color.FromArgb(248, 248, 255)); }

        }

        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox_path_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox_path.Text = path;
            textBox_path.Text = textBox_path.Text.Replace("\\", "//");
            fileName = textBox_path.Text.Split('/').Last();
            label2_INFO.Text = "目录已更新：" + textBox_path.Text;
            setInfoColor(Color.FromArgb(60, 179, 113),Color.FromArgb(248, 248, 255));
        }

        
        public void setInfoColor()
        {
            this.label2_INFO.BackColor = defaultBackColor;
            this.label2_INFO.ForeColor = defaultforeColor; 

        }
        /// <summary>
        /// 设定提示标签颜色，提供2个Color参数值
        /// </summary>
        /// <param name="para_BackColor">背景色</param>
        /// <param name="para_foreColor">前景色</param>
        public void setInfoColor(Color para_BackColor,Color para_foreColor)
        {
           
            this.label2_INFO.BackColor = para_BackColor;
            this.label2_INFO.ForeColor = para_foreColor; 
        }

        public void button_data_Click(object sender, EventArgs e)
        {
            // 获取当前tool 与 wobj
           
            try
            {
                tool = controller.MotionSystem.ActiveMechanicalUnit.Tool;
                w = controller.MotionSystem.ActiveMechanicalUnit.WorkObject;
             //   toolData = (ToolData)tool.Data;
              //  wobjData = (WobjData)w.Data;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"错误"); }
            activeWindow(new dataMonitor());
        } 

        private void button7_Click(object sender, EventArgs e)
        {
            string CodePath = Application.StartupPath + "/CodeExported/";
            if (false == System.IO.Directory.Exists(CodePath))
            {
                if (MessageBox.Show("文件夹未初始化，是否创建文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.IO.Directory.CreateDirectory(CodePath);
                    System.Diagnostics.Process.Start(CodePath);
                }
            }
            else { System.Diagnostics.Process.Start(CodePath); }
        }

        private void label_controllerState_Click(object sender, EventArgs e)
        {
            try
            {
                label_controllerState.Text = "当前控制器状态：" + controller.State.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // TODO: 实时更新控制器状态 
        }
        public void checkVisibleSonForm()
        {
            if (panel2.Visible == true || panel3.Visible == true)
            {
                panel_sonForm.Visible = false;
            }
        }

        private void button_fresh_Click(object sender, EventArgs e)
        {
            listBox_insertedCodelist.Items.Clear();
            string[] files = Directory.GetFiles(InsertedCodePath,"*");
            foreach (string item in files)
            {
                listBox_insertedCodelist.Items.Add(item.Split('\\').Last());
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            ReplaceValue(textBox_path.Text.Replace("//", @"\"),listBox_insertedCodelist.SelectedItem.ToString().Split('.').First());
             label2_INFO.Text = "代码段已插入" ;
            setInfoColor(Color.FromArgb(30, 144, 255), Color.FromArgb(248, 248, 255));
        }

        /// <summary>
        /// 替换值
        /// </summary>
        /// <param name="strFilePath">txt等文件的路径</param>
        /// <param name="strIndex">索引的字符串，定位到某一行</param>
        private void ReplaceValue(string strFilePath, string strIndex)
        {
            int varLine = 0;
            int endvarLine = 0;
            string varriable = "";
            string newValue = "";
            int moduleLine = 0;
            if (File.Exists(strFilePath))
            {
                string[] lines = System.IO.File.ReadAllLines(strFilePath);
                string[] lines2 = System.IO.File.ReadAllLines(InsertedCodePath + listBox_insertedCodelist.SelectedItem.ToString());
                // variable Line handle
                if (checkBox_InsertVar.Checked == true)
                {
                    for (int i = 0; i < lines2.Length; i++)
                    {
                        if (lines2[i].Contains("var:")) { varLine = i; }
                        if (lines2[i].Contains("endvar;")) { endvarLine = i; }
                    }
                    // get var array from lines2
                    for (int a = varLine + 1; a < endvarLine; a++)
                    {
                        varriable = varriable + lines2[a] + "\n";
                    }
                }
                // init newValue from lines2
                for (int i = endvarLine; i < lines2.Length; i++)
                {
                    newValue = newValue + lines2[i] + "\n";
                }
                for (int a = 0; a < lines.Length; a++)
                {
                    // 欲写变量 获取module行索引 变量写其下
                    if (checkBox_InsertVar.Checked == true)
                    {
                        if (lines[a].Contains("MODULE"))
                        {
                            if (lines[a].Contains("ENDMODULE")) { continue; }  // 避免
                            Console.WriteLine("MODULE LINE:" + a);
                            moduleLine = a;
                            lines[moduleLine + 1] = varriable;
                        }
                    }
                    if (lines[a].Contains("!" + strIndex))
                    {// 替换、插入新值
                        lines[a] = newValue;
                    }
                }
                File.WriteAllLines(strFilePath, lines);
            }
        }
        
        private void button_checkProgramm_Click(object sender, EventArgs e)
        {
            try
            {
                tRob1 = controller.Rapid.GetTask("T_ROB1");
                ReadOnlyCollection<ProgramError> errors = tRob1.CheckProgram().Errors;
                if (errors == null)
                { MessageBox.Show("可以···未检查到程序错误！"); }
                else
                {

                    foreach (ProgramError programError in errors)
                    {
                        string taskName = programError.TaskName;
                        string moduleName = programError.ModuleName;
                        int Line = programError.Line;
                        int column = programError.Column;
                        MessageBox.Show($"(っ °Д °;)っ发现程序错误！\n Task:{taskName} \n 模块:{moduleName} \n 出现在第 {Line} 行 \n 第 {column} 列");
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"错误"); }
        }

        private void button_loadModule_Click(object sender, EventArgs e)
        {
            loadModule();
        }

        /// <summary>
        /// 加载控制器上的rapid程序
        /// </summary>
        void loadModule()
        {
            try
            {
                tRob1 = controller.Rapid.GetTask("T_ROB1");
                string filePath = controller.FileSystem.GetRemotePath(listBox2_fileStore.SelectedItem.ToString());
                Console.WriteLine("目录：" + filePath);
                string ProgramFileName = Path.ChangeExtension(filePath, ".mod");
                using (Mastership m = Mastership.Request(controller))
                {
                    tRob1.LoadModuleFromFile(Path.GetFileName(filePath), RapidLoadMode.Replace);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message,"错误");
            }
        }


        public void CtrlRestart(Controller ctrl)
        {
            ctrl.Logon(UserInfo.DefaultUser);
            try
            {
                if (ctrl.OperatingMode == ControllerOperatingMode.Auto)
                {
                    using (Mastership.Request(ctrl))
                    {
                        ctrl.Restart(ControllerStartMode.Warm);
                    }
                }
                else
                {
                    MessageBox.Show("需要打开自动模式");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Mastership problem." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message);
            }
            ctrl.Logoff();//should be unecessary since we get kicked out at restart.
        }

        private void button_resetPoint_Click(object sender, EventArgs e)
        {
            ctrlCore.RAPID_ProgramReset(controller, "T_ROB1");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Point p1 = new Point(this.button4.Location.X-100, this.button4.Location.Y + 10);
            p2 = PointToScreen(p1);
            customMessageBox win = new customMessageBox();
            win.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageContent = "窗口加载成功！";
        }

        public void ShowNewMessage(string AMessage)
        {
            MessageContent = AMessage;
            button4_Click_1(null,null);
        }

        // 隐藏到托盘
        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { config.Write("cfgInit", "AutoConnect", "1", cfgPath); }
            else { config.Write("cfgInit", "AutoConnect", "0", cfgPath); }
        }

        private void label_OpenCfgFile_Click(object sender, EventArgs e)
        {
            Process.Start(cfgPath);
        }



        /// <summary>
        /// 单独form显示img
        /// </summary>
        /// <param name="resourceImg">提供资源库中的一个image</param>
        public void Showimg(Image resourceImg)
        {
            form_ShowImg form_ShowImg = new form_ShowImg();
            form_ShowImg.Show();
            form_ShowImg.Size = new Size(643, 877);
            Image a = resourceImg;
            form_ShowImg.BackgroundImage = a;
        }

        private void listBox2_fileStore_DoubleClick(object sender, EventArgs e)
        {
            //TODO: 载入新目录
           // string dir = controller.FileSystem.GetRemotePath(listBox2_fileStore.SelectedItem.ToString());
           //dir.
           // controller.FileSystem.GetFile

        }

        private void refreshModuleList()
        {
            listBox_moduleList.Items.Clear();

            tRob1 = controller.Rapid.GetTask("T_ROB1");
            Module[] module = tRob1.GetModules();

            foreach (Module modFiles in module)
            {
                listBox_moduleList.Items.Add(modFiles) ;
            }

        }

        private void button_saveModule_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mastership m = Mastership.Request(controller))
                {
                    Module module = (Module)listBox_moduleList.SelectedItem;
                    module.SaveToFile(controller.FileSystem.RemoteDirectory);
                    //   tRob1.SaveProgramToFile(controller.FileSystem.LocalDirectory);
                    // + @"\" + textBox_fileName.Text +".mod"
                    ShowNewMessage("保存完毕啦···目录：" + controller.FileSystem.LocalDirectory);
                    m.Release();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"保存发生错误");
            }
        }

        private void button_refreshModFiles_Click(object sender, EventArgs e)
        {
            try
            {
                refreshModuleList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

