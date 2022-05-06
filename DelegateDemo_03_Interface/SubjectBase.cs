using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo_03_Interface
{
    public abstract class SubjectBase:IObservable
    {
        //定义一个观察者的容器
        private List<IObserver> container = new List<IObserver>();

        public void Register(IObserver obj)
        {
            container.Add(obj);
        }

        public void UnRegister(IObserver obj)
        {
            container.Remove(obj);
        }

        protected virtual void Notify()
        {
            foreach(IObserver observer in container)
            {
                observer.Update();



                Task task = Task.Run(() => Console.WriteLine(""));

                var awaiter = task.GetAwaiter();

                awaiter.OnCompleted(() => Console.WriteLine(""));
            }
        }
    }
}
