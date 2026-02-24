using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int a=int.Parse(Console.ReadLine());

            int fact = 1;

            for(int i=a;i>=1;i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial=" + fact);
        }
    }
}
