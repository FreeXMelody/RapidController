using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.IOSystemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABB.Robotics.Controllers.RapidDomain;
namespace rapid2Controler
{
    class ctrlCore
    {
        /// <summary>
        ///  //重置Task程序指针 
        /// </summary>
        /// <param name="controller">控制器</param>
        /// <param name="taskname">任务名称</param>
        /// <returns>返回值</returns>
        public static void  RAPID_ProgramReset(Controller controller, string taskname)
        {
            try
            {
                using (Mastership m = Mastership.Request(controller))//写权限
                {
                    controller.Rapid.GetTask(taskname).ResetProgramPointer();//复位程序指针
                    m.Release();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message,"错误");
            }
        }



        /// <summary>
        /// 设置IO
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="IOName"></param>
        /// <returns></returns>
        public static string SetIOStatus(Controller controller, string IOName)//设置IO
        {
            ABB.Robotics.Controllers.IOSystemDomain.DigitalSignal sig;
            controller.Logon(ABB.Robotics.Controllers.UserInfo.DefaultUser);
            if (controller.OperatingMode != ControllerOperatingMode.Auto)//自动模式
            {
                return null;
            }
            if (!controller.AuthenticationSystem.CheckDemandGrant(Grant.ExecuteRapid))//可执行
                controller.AuthenticationSystem.DemandGrant(Grant.ExecuteRapid);

            try
            {
                Signal Dout = controller.IOSystem.GetSignal(IOName);
                sig = (ABB.Robotics.Controllers.IOSystemDomain.DigitalSignal)Dout;
                sig.Set();
                return sig.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误");
            }
            return null;
        }
        /// <summary>
        /// 复位IO
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="IOName"></param>
        /// <returns></returns>
        public static string ResetIOStatus(Controller controller, string IOName)//复位IO
        {
            ABB.Robotics.Controllers.IOSystemDomain.DigitalSignal sig;
            controller.Logon(ABB.Robotics.Controllers.UserInfo.DefaultUser);
            if (controller.OperatingMode != ControllerOperatingMode.Auto)//自动模式
            {
                return null;
            }
            if (!controller.AuthenticationSystem.CheckDemandGrant(Grant.ExecuteRapid))//可执行
                controller.AuthenticationSystem.DemandGrant(Grant.ExecuteRapid);

            try
            {
                Signal Dout = controller.IOSystem.GetSignal(IOName);
                sig = (ABB.Robotics.Controllers.IOSystemDomain.DigitalSignal)Dout;
                sig.Reset();
                return sig.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
            return null;
        }
        /// <summary>
        /// 读取IO状态
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="IOName"></param>
        /// <returns></returns>
        public static string ReadIOStatus(Controller controller, string IOName)//读取IO状态
        {
            try
            {
                controller.Logon(ABB.Robotics.Controllers.UserInfo.DefaultUser);
                if (controller.OperatingMode != ControllerOperatingMode.Auto)//自动模式
                {
                    return "检测到非自动模式";
                }
                if (!controller.AuthenticationSystem.CheckDemandGrant(Grant.ExecuteRapid))//可执行
                    controller.AuthenticationSystem.DemandGrant(Grant.ExecuteRapid);
                try
                {
                    Signal DIO = controller.IOSystem.GetSignal(IOName);
                    //ABB.Robotics.Controllers.IOSystemDomain.DigitalSignal sig;
                    //sig = (ABB.Robotics.Controllers.IOSystemDomain.DigitalSignal)DIO;
                    //return sig.Value.ToString();
                    string sig = DIO.Value.ToString();
                    return sig;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
            return null;

        }


    }
}
