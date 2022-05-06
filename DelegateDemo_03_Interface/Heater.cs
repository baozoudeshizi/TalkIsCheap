using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo_03_Interface
{
    public class Heater:SubjectBase
    {
        private string type;        // 添加型号作为演示
        private string area;        // 添加产地作为演示
        private int temprature;        // 水温

        public Heater(string type, string area)
        {
            this.type = type;
            this.area = area;
            temprature = 0;
        }

        public string Type { get { return type; } }
        public string Area { get { return area; } }

        public Heater() : this("RealFire 001", "China AnHui") { }


        // 供子类覆盖，以便子类拒绝被通知，或添加额外行为
        protected virtual void OnBoiled()
        {
            base.Notify();// 调用父类Notify()方法，进而调用所有注册了Observer的Update()方法
        }

        //烧水
        public void BoilWater()
        {
            for(int i = 0; i < 99; i++)
            {
                temprature = i + 1;
                if (temprature > 96) //当水快烧开时，通知Observer
                {
                    OnBoiled();
                }
            }
        }
    }
}
