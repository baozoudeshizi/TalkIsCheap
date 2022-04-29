using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace TimerTest0426
{
    public class TimeTest
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        public TimeTest()
        {
            // timer init
            Console.WriteLine(DateTime.Now + ":TimeTest初始化执行！");
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(Periodic);
            timer.Enabled = true;
            timer.AutoReset = true;
            
        }

        private void Periodic(object sender, ElapsedEventArgs e)
        {
            //Console.WriteLine(DateTime.Now + ":定时任务被执行！");
            Console.WriteLine(DateTime.Now + ":定时任务被执行!当前线程是：" + Thread.CurrentThread.GetHashCode());
            Console.WriteLine(DateTime.Now + ":当前线程是否是线程池：" + Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine(DateTime.Now + ":当前线程是否是Background：" + Thread.CurrentThread.IsBackground);

        }
    }
}
