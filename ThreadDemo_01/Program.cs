using System;
using System.Threading;

namespace ThreadDemo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ThreadStart ts = new ThreadStart();
            Thread th = new Thread(test);
            Thread th1 = new Thread(test1);
            th.Start();
            Console.ReadKey();
        }

        private static void test1(object obj)
        {
            throw new NotImplementedException();
        }

        private static void test(object obj)
        {
            Console.WriteLine("线程开始啦！！！");
        }
    }
}
