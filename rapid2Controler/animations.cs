using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;

namespace rapid2Controler
{
    class animations
    {
        // TODO:难整·····
        static Form MainForm = new Form();
        public static System.Timers.Timer timer;
        public delegate void SetControlValue(string value); // 定义委托
        public static void opacityChange(Form form)
        {
            MainForm = form;
            double Interval = 20;
            timer = new System.Timers.Timer(Interval);
            timer.AutoReset = true;

            // opacity = 0 执行事件
            if (MainForm.Opacity == 100) {}
            else
            {
                timer.Enabled = true; // 允许执行timer.elapsed事件
                timer.Elapsed += new ElapsedEventHandler(ATimerStart); // 绑定Elapsed事件
            }
        
        }

        private static void ATimerStart(object source, ElapsedEventArgs e) // 开始
        {
            if (MainForm.Opacity == 100) { timer.Enabled = false; }
            OpacityPlus();
        }
        private static void OpacityPlus()
        {
            MainForm.Opacity += 1;
        }

        public class  Win32
        {

            public const Int32 AW_HOR_POSITIVE = 0x00000001;     // 从左到右打开窗口

            public const Int32 AW_HOR_NEGATIVE = 0x00000002;     // 从右到左打开窗口

            public const Int32 AW_VER_POSITIVE = 0x00000004;     // 从上到下打开窗口

            public const Int32 AW_VER_NEGATIVE = 0x00000008;     // 从下到上打开窗口

            public const Int32 AW_CENTER = 0x00000010;

            public const Int32 AW_HIDE = 0x00010000;         // 在窗体卸载时若想使用本函数就得加上此常量

            public const Int32 AW_ACTIVATE = 0x00020000;     //在窗体通过本函数打开后，默认情况下会失去焦点，除非加上本常量

            public const Int32 AW_SLIDE = 0x00040000;

            public const Int32 AW_BLEND = 0x00080000;        // 淡入淡出效果

            [DllImport("user32.dll", CharSet = CharSet.Auto)]

            public static extern bool AnimateWindow(

            IntPtr hwnd,   //   handle   to   window   

            int dwTime,   //   duration   of   animation   

            int dwFlags   //   animation   type   

            );

        }
    }
}
