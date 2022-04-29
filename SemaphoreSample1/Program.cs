using System;
using System.Threading;

namespace SemaphoreSample1
{
    class Program
    {
        /***
         * 
         * 信号量可用于限制并发性，防止太多的线程同时执行特定的代码。
         * 在下面的例子中，5个线程试图进入，但最多只允许3个线程同时进入
         * 
         */
        static SemaphoreSlim _sem = new SemaphoreSlim(3);
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                new Thread(Enter).Start(i);
            }
            Console.ReadKey();
        }

        private static void Enter(object id)
        {
            Console.WriteLine(DateTime.Now + ": " + id + " wants to enter");
            _sem.Wait();
            Console.WriteLine(DateTime.Now +": " + id + " is in!");       // Only three threads
            Thread.Sleep(1000 * (int)id);               // can be here at
            Console.WriteLine(DateTime.Now + ": " + id + " is leaving");   // a time.
            _sem.Release();
        }
    }
}
