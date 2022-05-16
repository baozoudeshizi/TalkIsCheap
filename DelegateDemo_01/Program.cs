using System;

namespace DelegateDemo_01
{
    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);

    public class GreetingManager
    {
        //注意此方法，它接受一个GreetingDelegate类型的方法作为参数
        public  void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
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
            gm.GreetPeople("Jimmy Zhang", EnglishGreeting);
            gm.GreetPeople("张子阳", ChineseGreeting);
            Console.ReadKey();

            GreetingDelegate delegate1;
            delegate1 = EnglishGreeting;
            delegate1 += ChineseGreeting;
            gm.GreetPeople("Jimmy Zhang",delegate1);
        }
    }
}
