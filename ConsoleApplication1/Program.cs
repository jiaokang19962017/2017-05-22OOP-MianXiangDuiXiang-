﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //string color = car.GetInfo();//调用颜色方法取值

            //int speed = car.speed;  //访问非静态字段
            ////Car.tank  //访问静态字段 
            //Console.WriteLine(color);
            car.OilMeter = 30; 
            car.PlusOil();
            car.PlusOil(60);
        }
        
    }
}
