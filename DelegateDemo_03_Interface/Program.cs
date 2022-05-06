using System;

namespace DelegateDemo_03_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Screen screen = new Screen();
            Alarm alarm = new Alarm();

            heater.Register(screen); //注册显示器
            heater.Register(alarm);  //注册热水器

            heater.BoilWater();//开始烧水
            heater.UnRegister(alarm); //取消报警器的注册

            Console.WriteLine();
            heater.BoilWater(); //再次烧水


        }
    }
}
