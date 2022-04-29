using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLockSample
{
    class Program
    {
            static void Main(string[] args)
            {
                int taskCount = 6;
                int SemaphoreCount = 3;
                Console.WriteLine($"有{taskCount}人来使用水龙头，水房总共有{SemaphoreCount}个水龙头");
                var semaphore = new SemaphoreSlim(SemaphoreCount, SemaphoreCount);

                var tasks = new Task[taskCount];
                for (int i = 0; i < taskCount; i++)
                {
                    tasks[i] = Task.Run(() => Washing(semaphore));
                }
                Task.WaitAll(tasks);
                Console.WriteLine(" 所有人都使用完了，全部资源释放。 ");
                Console.ReadLine();
            }

            public static void Washing(SemaphoreSlim semaphore)
            {
                bool isCompleted = false;
                while (!isCompleted)
                {
                    if (semaphore.Wait(4000))
                    {
                        try
                        {
                            Task.Delay(2000).Wait();
                            Console.WriteLine(DateTime.Now + $"{Task.CurrentId} 正在使用水龙头 ，锁定了资源。");
                        }
                        finally
                        {
                            Console.WriteLine(DateTime.Now + $"{Task.CurrentId} 已经使用完了水龙头，释放了资源。");
                            semaphore.Release();
                            isCompleted = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine(DateTime.Now + $"{Task.CurrentId}; 正在等待资源 。");
                    }
                }
            }
        }
    }
