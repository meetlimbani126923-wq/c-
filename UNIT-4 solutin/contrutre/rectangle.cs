using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contrutre
{
    internal class rectangle
    {
        int l, w, area;
        public rectangle()
        {
            l = 10;
            w = 20;
        }
        public rectangle(int l1, int w1 )
        {
            l = l1;
            w= w1;
          
        }
        public void calculate()
        {
            area = l * w;
        }
        public void display()
        {

            Console.WriteLine("area is -->" + area);

        }
    }
}
