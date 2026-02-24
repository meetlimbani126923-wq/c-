using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.getdata();
            r.calculate();
            r.display();

            cricle c = new cricle();
            c.getdata();
            c.cal();
            c.display();


        }
    }
}
