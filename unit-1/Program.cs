using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace unit_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("hello");
            Console.WriteLine("Enter value a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = b * c;
            int f = a / d;

            Console.WriteLine("ANS");
            Console.WriteLine("Sum" + c);
            Console.WriteLine("Sub" + d);
            Console.WriteLine("Mul" + e);
            Console.WriteLine("div" + f);        }
    }
}
