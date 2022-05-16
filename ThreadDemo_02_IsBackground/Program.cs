using System;
using System.Threading;

namespace ThreadDemo_02_IsBackground
{
    class Program
    {
        public delegate void aaa();
        static void Main(string[] args)
        {
            string name = "Main  ";
            Thread.CurrentThread.Name = name;

            aaa bbb;
            bbb = ThreadEntry;
            bbb += ThreadEntry;

            ThreadStart ts = new ThreadStart(ThreadEntry);

            aaa ts1 = new aaa(ThreadEntry);
            Thread worker = new Thread(ts1);
            //Thread worker1 = new Thread(ThreadEntry);
            //worker.IsBackground = true;
            //worker.Name = "Worker";
            //Console.WriteLine("{0}: Worker Status - {1}",
            //        name, worker.ThreadState);
            //worker.Start();

            //Console.WriteLine("{0}: Worker Status - {1}",
            //        name, worker.ThreadState);
            //Console.WriteLine("{0}: End", name);
        }

        static void ThreadEntry()
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine("{0}: Start", name);
            Thread.Sleep(100);        // 停留100毫秒
            Console.WriteLine("{0}: End", name);
        }

        
    }
}
