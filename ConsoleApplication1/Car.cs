using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
       private string color;     //汽车颜色
        private double weight; //汽车的重量
        private double price;  //汽车的价格
        private readonly int tank = 100;  //汽车的油箱的容积
        private int oilMeter;     //汽车的油表
        private int speed;  //最高时速
        private string[] style;// 定义一个数组类型的变量,存放汽车类型



        public string this[int index]
        {
            get { return style[index]; }
            set { style[index] = value; }
        }
        public Car()
        {
            style = new string[] { "跑车", "轿车", "SUV" };
        }

        public Car(string name)
        {
            Console.WriteLine(name);
        }
        /*共有属性:外界可以直接访问并且赋值
         私有属性:外界不可访问,但是可以通过本类方法进行间接访问*/
        public string Color
        {
            get { return color; }//取值操作
            set { color = value; }//赋值操作
        }

        public double Price //只读操作,没有set访问器,只写操作,没有get访问器
        {
            get
            {
                if (price > 5000)
                {
                    price = 5000;
                }
                return price;
            }
            set
            {
                //    if (value > 5000)
                //    {
                //        price = 5000;
                //    }
                //    else
                //    {
                //        price = value;
                //    }
                price = value;

            }
        }

        public int OilMeter
        {
            get { return oilMeter; }//取值操作
            set { oilMeter = value; }//赋值操作
        }
        public string GetInfo()
        {
            Color = "red";//对属性进行赋值操作
            string color = Color;//对属性进行取值操作
            return color;
        }
        //public static int Tank  //静态属性:必须是静态字段
        //{
        //    get { return tank; }
        //    set { tank = value; }
        //}

     

        public void PlusOil() //加油方法
        {
            Console.WriteLine("加油成功");
        }
        public void PlusOil(int oilNumber) //加油方法重载
        {
            if (oilNumber + oilMeter > 100)
            {
                Console.WriteLine("失败,油箱已满");
            }
            else
            {
                Console.WriteLine("一共加了{0}升油",oilNumber);
                Console.WriteLine("油表数为{0}",oilMeter);
            }
        }
    }
}
