using System;

namespace DelegateDemo_01_Event
{
    /***
     * 对DelegateDemo_01_Wrap的进一步包装，引入Event
     * 
     * ***/

    public delegate void GreetingDelegate(string name);
    public class GreetingManager
    {
        //声明一个事件，在委托类型前面又多了个event修饰符
        public event GreetingDelegate MakeGreet;

        public void GreetPeople(string name)
        {
            MakeGreet(name);
        }

    }

    class Program
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        static void Main(string[] args)
        {
            GreetingManager gm = new GreetingManager();
            gm.MakeGreet += EnglishGreeting; //不能用赋值，会报错了
            gm.MakeGreet += ChineseGreeting;

            gm.GreetPeople("Jimmy Zhang");
        }
    }
}
