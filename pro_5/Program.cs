using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("circle area");

            Console.WriteLine("Enter r Value");
            float r = int.Parse(Console.ReadLine());

            float pi = 3.14f;

            float c = pi * r * r;

            Console.WriteLine("area of circle is     " + c);

        }
    }
}
