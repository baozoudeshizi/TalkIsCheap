using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Event_Observer
{
    public class Subscriber
    {
        public void OnNumberChanged(int count)
        {
            Console.WriteLine("Subscriber notified: count = {0}", count);
        }
    }
}
