using System;

namespace DelegateDemo_02_VsInterface
{
    /***
     * 
     * 使用委托定义了方法的签名，从而隔离了变化，此处所指的变化即为方法体内的具体实现
     * 下面的代码使用接口完成了与使用委托时完全相同的功能
     * 在使用接口时，代码量增大了很多，而且还需要定义实现了接口的类，利用的是多态
     * ***/
    public interface IGreeting
    {
        void GreetingPeople(string name);
    }

    public class EnglishGreeting : IGreeting
    {
        public void GreetingPeople(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
    }

    public class ChineseGreeting : IGreeting
    {
        public void GreetingPeople(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
    }

    class Program
    {
        private static void GreetPeople(string name, IGreeting makeGreeting)
        {
            makeGreeting.GreetingPeople(name);
        }

        static void Main(string[] args)
        {
            GreetPeople("Jimmy Zhang", new EnglishGreeting());
            GreetPeople("张子阳", new ChineseGreeting());
            Console.ReadKey();
        }
    }
}
