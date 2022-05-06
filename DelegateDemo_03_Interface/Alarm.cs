using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Interface
{
    public class Alarm : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Alarm".PadRight(7) + "：嘟嘟嘟，水温快烧开了。");
        }
    }
}
