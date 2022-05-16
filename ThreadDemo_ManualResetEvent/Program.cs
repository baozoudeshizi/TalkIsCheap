using System;
using System.Threading;

namespace ThreadDemo_ManualResetEvent
{
    class Program
    {
        ManualResetEvent mre = new ManualResetEvent(true); // signaled

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main  ";
            Program p = new Program();
            Thread worker = new Thread(p.ThreadEntry);
            worker.Name = "Worker";
            worker.Start();
            Console.WriteLine("Main  : Finished");
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
