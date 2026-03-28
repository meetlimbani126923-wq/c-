using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, temp, sum = 0, rem;

            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());

            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("It is Armstrong");
            }
            else
            {
                Console.WriteLine("It is not Armstrong");
            }
        }
    }
}
