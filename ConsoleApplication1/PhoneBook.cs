using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PhoneBook
    {
        public string Name { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }

        public string Phone { get; set; }
        public string QQ { get; set; }

        public string Add { get; set; }


        public void PrintInfo (){
            string strinfo = string.Format("{0}{1}{2}{3}{4}{5}",Name, Sex, Age, Phone, QQ, Add);
            Console.WriteLine(strinfo);
        }
    }
}
