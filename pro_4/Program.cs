using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pro_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" compound intrest");

            Console.WriteLine(" Enter Principle Value ");
            float p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate Value ");
            float r = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Year Value");
            float n = int.Parse(Console.ReadLine());

            float simple = p * r * n / 100;
            float total = simple + p;
            float c = total * r / 100;
            float com = c + total;

            Console.WriteLine("simple      " + simple);
            Console.WriteLine("total       " + total);
            Console.WriteLine("compound    " + c);
            Console.WriteLine("compound intrst" + com);


        }
    }
}
