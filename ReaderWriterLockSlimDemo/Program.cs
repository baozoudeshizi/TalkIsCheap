using System;
using System.Collections.Generic;
using System.Threading;

namespace ReaderWriterLockSlimDemo
{
    /***
     * 
     * 三个线程将持续枚举列表中的元素，而另外两个线程则会每隔100毫秒生成一个随机数，并试图将该数字加入列表中。
     * 其中，读锁保护列表的读操作，而写锁保护列表的写操作
     * 
     * 
     * **/
    class Program
    {
        static ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        static List<int> _items = new List<int>();
        static Random _rand = new Random();

        static void Main()
        {
            new Thread(Read).Start();
            new Thread(Read).Start();
            new Thread(Read).Start();

            new Thread(Write).Start("A");
            new Thread(Write).Start("B");
        }

        static void Read()
        {
            while (true)
            {
                _rw.EnterReadLock();
                foreach (int i in _items)
                {
                    Thread.Sleep(10);
                }
                _rw.ExitReadLock();
            }
        }

        static void Write(object threadID)
        {
            while (true)
            {
                Console.WriteLine(_rw.CurrentReadCount + " concurrent readers");
                int newNumber = GetRandNum(100);
                _rw.EnterWriteLock();
                _items.Add(newNumber);
                _rw.ExitWriteLock();
                Console.WriteLine(DateTime.Now+ ": Thread " + threadID + " added " + newNumber);
                Thread.Sleep(100);
            }
        }

        static int GetRandNum(int max) 
        { 
            lock (_rand) 
                return _rand.Next(max); 
        }
    }
}
