using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_GetDelegateList
{
    public delegate string DemoEventHandler(int num);
    public class Publisher
    {

        public event DemoEventHandler NumberChanged;        // 声明一个事件
        public List<string> DoSomething()
        {
            // 做某些其他的事

            List<string> strList = new List<string>();
            if (NumberChanged == null) return strList;

            // 获得委托数组
            Delegate[] delArray = NumberChanged.GetInvocationList();

            foreach (Delegate del in delArray)
            {
                // 进行一个向下转换
                DemoEventHandler method = (DemoEventHandler)del;
                method.DynamicInvoke();
                strList.Add(method(100));                // 调用方法并获取返回值
            }

            return strList;
        }

    }

    // 定义事件订阅者
    public class Subscriber1
    {
        public string OnNumberChanged(int num)
        {
            Console.WriteLine("Subscriber1 invoked, number:{0}", num);
            return "[Subscriber1 returned]";
        }
    }
    public class Subscriber2
    {
        public string OnNumberChanged(int num)
        {
            Console.WriteLine("Subscriber2 invoked, number:{0}", num);
            return "[Subscriber2 returned]";
        }
    }
    public class Subscriber3
    {
        public string OnNumberChanged(int num)
        {
            Console.WriteLine("Subscriber3 invoked, number:{0}", num);
            return "[Subscriber3 returned]";
        }
    }
}
