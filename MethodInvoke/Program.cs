using System;
using System.Reflection;

namespace MethodInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string s = "hello";
            //int length = s.Length;

            //object ss = "hello";
            //object sss = "hello world";
            //PropertyInfo prop = s.GetType().GetProperty("Length");
            //int length1 = (int)prop.GetValue(ss);
            //int length2 = (int)prop.GetValue(sss);
            //Console.WriteLine("length1的长度："+length1);
            //Console.WriteLine("length2的长度：" + length2);

            string s = "hello world";
            //s.Substring();
            Type type = typeof(string);
            Type[] paramTypes = { typeof(string) };
            MethodInfo method = type.GetMethod("Substring", paramTypes);
            MethodInfo method1 = type.GetMethod("Substring");

            object[] arguments = { 2 };
            object returnValue = method.Invoke(s, arguments);
            Console.WriteLine(returnValue);
            Console.ReadKey();
        }
    }
}
