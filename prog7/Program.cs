using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter tha age");
            int age= int.Parse(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("Kid");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("you are tenegaer");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("you are adult");
            }
            else
            {
                Console.WriteLine("you are the citizen");
            }

        }
    }
}
