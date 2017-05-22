using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0&&value>120)
                {
                    Console.WriteLine("输入有误,超出年龄范围");
                }
                age = value;
            }
        }
    }
}
