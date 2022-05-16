using System;
using System.Threading;

namespace ThreadDemo_AutoResetEvent
{
    class Program
    {
        AutoResetEvent mre = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main  ";
            Program p = new Program();
            Thread worker = new Thread(p.ThreadEntry);
            worker.Name = "Worker";
            worker.Start();

            Console.WriteLine("Main  : Start worker.");
            p.mre.Set();
            Thread.Sleep(100);

            Console.WriteLine("Main  : worker Go.");
            p.mre.Set();
            Thread.Sleep(100);
        }

        void ThreadEntry()
        {
            int i = 0;
            string name = Thread.CurrentThread.Name;
            while (i < 10)
            {
                mre.WaitOne();
                Console.WriteLine("{0}: [{1} - {2}]", name, i, DateTime.Now.
Millisecond);
                i++;
            }
        }
    }
}
