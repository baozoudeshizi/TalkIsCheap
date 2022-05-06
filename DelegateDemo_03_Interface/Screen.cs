using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Interface
{
    public class Screen:IObserver
    {
        // Subject在事件发生时调用，通知Observer更新状态(通过Notify()方法)
        public void Update()
        {
            Console.WriteLine("Screen".PadRight(7) + ": 水快烧开了。");
        }
    }
}
