using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> list = new List<string>();
            list.Add("11");
            ConcurrentDictionary<string, string> aa = new ConcurrentDictionary<string, string>();
        }
    }
}
