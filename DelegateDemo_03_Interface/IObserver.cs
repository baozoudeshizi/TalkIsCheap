using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Interface
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        // 事件触发时由Subject调用，而非观察者调用，更新自身状态
        // 如在主题Notify方法中调用
        void Update();       
    }
}
