using System;
using System.Collections.Generic;

namespace DelegateDemo_03_GetDelegateList
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();

            pub.NumberChanged += new DemoEventHandler(sub1.OnNumberChanged);
            pub.NumberChanged += new DemoEventHandler(sub2.OnNumberChanged);
            pub.NumberChanged += new DemoEventHandler(sub3.OnNumberChanged);

            List<string> list = pub.DoSomething();        //调用方法，在方法内触发事件

            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
