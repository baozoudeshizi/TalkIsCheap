using System;
using System.Threading;

namespace TimerTest0426
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now + ":初始化第一个TimeTest!");
            for (int i = 0; i < 1; i++)
            {
                TimeTest t = new TimeTest();
            }

            Thread.Sleep(3000);
            Console.WriteLine(DateTime.Now + ":初始化第二个TimeTest!");
            TimeTest t1 = new TimeTest();


            Thread.Sleep(3000);
            Console.WriteLine(DateTime.Now + ":初始化第三个TimeTest!");
            TimeTest t2 = new TimeTest();

            Console.ReadLine();
        }
    }
}
