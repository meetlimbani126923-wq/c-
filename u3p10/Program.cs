using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, temp, rev = 0, rem;

            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());

            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;
            }

            if (temp == rev)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It is not palindrome");
            }
        }
    }
}
