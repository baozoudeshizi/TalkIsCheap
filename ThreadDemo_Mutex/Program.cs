using System;
using System.Threading;

namespace ThreadDemo_Mutex
{
    class Program
    {
        private string called = "";
        private Mutex mtx = new Mutex();

        static void Main(string[] args)
        {
            Program p = new Program();

            Thread.CurrentThread.Name = "Main  ";
            Thread worker = new Thread(p.ThreadEntry);
            worker.Name = "Worker";
            worker.Start();
            p.ThreadEntry();
            Console.ReadKey();
        }

        void ThreadEntry()
        {
            this.mtx.WaitOne();
            string name = Thread.CurrentThread.Name;
            called += String.Format("{0}: [{1}] ", name, DateTime.Now.Millisecond);
            Console.WriteLine(called);
            this.mtx.ReleaseMutex();
        }
    }
}
