using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Interface
{
    /// <summary>
    /// 被观察者的接口
    /// </summary>
    public interface IObservable
    {
        //注册
        void Register(IObserver obj);

        //取消注册
        void UnRegister(IObserver obj);
    }
}
