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
        static Form MainForm = new Form();
        public static System.Timers.Timer timer;
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

    }
}
