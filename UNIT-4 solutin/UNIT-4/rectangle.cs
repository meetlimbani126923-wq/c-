using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class rectangle
    {
        int l, w, area;
        
        public void getdata()
        {
            Console.WriteLine("enter lenghth");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("enter width");
            w = int.Parse(Console.ReadLine());


        }

        public void calculate()
        {
            area = l * w;

        }
        public void display()
        {
            Console.WriteLine("area: " + area);
        }
    }
}

    

