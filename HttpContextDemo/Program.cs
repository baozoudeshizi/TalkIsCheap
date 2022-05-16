using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HttpContextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //// 设置当前线程HostContext
            //CallContext.HostContext = new Dictionary<string, string>
            //{
            //    ["ContextKey"] = "ContextValue"
            //};
            //// await前，可以正常访问
            //Console.Write($"[{Thread.CurrentThread.ManagedThreadId}] await before：");
            //Console.WriteLine(((Dictionary<string, string>)CallContext.HostContext)["ContextKey"]);

            //await Task.Delay(100);

            //// await后，切换了线程，无法访问
            //Console.Write($"[{Thread.CurrentThread.ManagedThreadId}] await after：");
            //Console.WriteLine(((Dictionary<string, string>)CallContext.HostContext)["ContextKey"]);

        }
    }


}
