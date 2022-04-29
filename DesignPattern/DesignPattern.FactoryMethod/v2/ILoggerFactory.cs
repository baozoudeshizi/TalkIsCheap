using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v2
{
    public interface ILoggerFactory
    {
        //对于同一个方法，有不同的传参实现。
        ILogger CreateLogger();
        ILogger CreateLogger(string args);
        ILogger CreateLogger(object obj);
    }
}
