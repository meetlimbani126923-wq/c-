using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" simpale intrest ");

            Console.WriteLine(" Enter Principle Value ");
            float p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate Value ");
            float r = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Year Value");
            float y = int.Parse(Console.ReadLine());

            double s = p * r * y / 100;

            Console.WriteLine("simpal " + s); 
        }
    }
}
