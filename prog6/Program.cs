using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter tha number");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("number is even");
            }  
            else
            {
                Console.WriteLine("number is odd");

            }
        }
    }
}
