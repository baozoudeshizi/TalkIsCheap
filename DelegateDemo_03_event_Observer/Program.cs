using System;

namespace DelegateDemo_03_Event_Observer
{



    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();

            //将sub的OnNumberChanged方法注册到pub的委托中
            pub.NumberChanged += new NumberChangedEventHandler(sub.OnNumberChanged);
            pub.DoSomething(); // 应该通过DoSomething()来触发事件
            //pub.NumberChanged(100);  // 也可以被这样直接调用，对委托变量的不恰当使用；当NumberChanged被Event修饰时，则无法这样调用

        }
    }
}
