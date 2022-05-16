using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Event_Observer
{
    public delegate void NumberChangedEventHandler(int count);
    public class Publisher
    {
        private int count;
        //public NumberChangedEventHandler NumberChanged;                // 声明委托变量
        public event NumberChangedEventHandler NumberChanged;        // 声明一个事件

        public void DoSomething()
        {
            if(NumberChanged != null) //为什么要判断是否为null
            {
                count++;
                NumberChanged(count);
            }
        }
    }
}
