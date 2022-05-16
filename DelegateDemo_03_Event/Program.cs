using System;

namespace DelegateDemo_01_Wrap
{
    public delegate void GreetingDelegate(string name);
    public class GreetingManager
    {
        //在GreetingManager类的内部声明delegate1变量
        public GreetingDelegate  delegate1;

        public void GreetPeople(string name)
        {
            if (delegate1 != null)
            {
                delegate1(name); // 如果有方法注册委托变量,通过委托调用方法
            }
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
            gm.delegate1 = EnglishGreeting;
            gm.delegate1 += ChineseGreeting;

            gm.GreetPeople("Jimmy Zhang");
        }
    }
}
