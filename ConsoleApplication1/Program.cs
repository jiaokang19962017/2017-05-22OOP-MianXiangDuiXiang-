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
            Car car = new Car();//创建汽车类的实例
            //string color = car.GetInfo();//调用颜色方法取值

            //int speed = car.speed;  //访问非静态字段
            ////Car.tank  //访问静态字段 
            //Console.WriteLine(color);
            //car.OilMeter = 30; 
            //car.PlusOil();
            //car.PlusOil(60);
            //PhoneBook pb = new PhoneBook();
            //pb.Name = "jiaokng";
            //pb.Age = 21;
            //pb.Add = "hahah";
            //pb.Sex = '男';
            //pb.QQ = "1511111";
            //pb.Phone = "1589633";
            //pb.PrintInfo();




            //获取索引器的值
            Car car4 = new Car();
            string first = car4[0];//通过对象的名称[index]来获取数组当中的元素
            string second = car4[1];
            string three = car4[2];

            Console.WriteLine("骑车的类型:{0},{1},{2}",first,second,three);
        }
        
    }
}
