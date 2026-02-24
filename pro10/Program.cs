using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number");
            int n =int.Parse(Console.ReadLine());
            int flag = 0;
            int m;
            for (int i = 2; i < n; i++)
            {
                m = n % i;

                if (m == 0)
                {
                    Console.WriteLine("not a prime number ");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("prime number");
            }

         

                  
          

         
        }
    }
}
