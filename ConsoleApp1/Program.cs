using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Remoting;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine(currentDomain.BaseDirectory);
            Console.WriteLine(currentDomain.DynamicDirectory);
            Console.WriteLine("Hello World!");

            //EnumToDictionary<Student>();
            Type t = typeof(Student);

            Student student = new Student();
            student.Clone();

            Assembly asm = Assembly.GetExecutingAssembly();
            Object obj = asm.CreateInstance("SimpleExplore.Calculator", true);

            ObjectHandle handler = Activator.CreateInstance(null, " SimpleExplore.Calculator");

            // Get the fields of the specified class.
            FieldInfo[] myField = t.GetFields();
            PropertyInfo[] propertyInfos = t.GetProperties();
            MethodInfo[] methodInfos = t.GetMethods();



            for (int i = 0; i < propertyInfos.Length; i++)
            {
                // Determine whether or not each field is a special name.
                if (propertyInfos[i].IsSpecialName)
                {
                    Console.WriteLine("The field {0} has a SpecialName attribute.",
                        propertyInfos[i].Name);
                }
            }





            //FieldInfo[] list = t.BaseType.GetFields();
            //FieldInfo[] list1 = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance| BindingFlags.Public);
            //foreach(var f in list)
            //{
            //    Console.WriteLine("Name =" + f.Name+";Value");
            //}
            Console.ReadKey();


        }

        /// <summary>
        /// 转成dictionary类型
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static Dictionary<int, string> EnumToDictionary<T>()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Type typeDescription = typeof(DescriptionAttribute);
            FieldInfo[] fields = typeof(T).GetFields();
            int sValue = 0;
            string sText = string.Empty;
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType.IsEnum)
                {
                    sValue = ((int)typeof(T).InvokeMember(field.Name, BindingFlags.GetField, null, null, null));
                    object[] arr = field.GetCustomAttributes(typeDescription, true);
                    if (arr.Length > 0)
                    {
                        DescriptionAttribute da = (DescriptionAttribute)arr[0];
                        sText = da.Description;
                    }
                    else
                    {
                        sText = field.Name;
                    }
                    dictionary.Add(sValue, sText);
                }
            }
            return dictionary;
        }


    }

    public class Student:ICloneable
    {
        public string Name { get; set; } = "hy";

        public int Age { get; set; }


        public bool IsGraduate;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public enum DataTypeEnum
    {
        [Description("目标物参数")]
        TargetCompound = 1,

        [Description("气相参数")]
        GasParams = 2,

        [Description("配置文件")]
        TransferConfig = 3,

    }

}
