using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class cricle
    {
        int r;
        double area;

        public void getdata()
        {
            Console.WriteLine("enter radious");
            r = int.Parse(Console.ReadLine());
        }
        public void cal()
        {
            area = 3.14 * r * r;
        }
        public void display()
        {
            Console.WriteLine("area = " + area);
        }


    }      
}
