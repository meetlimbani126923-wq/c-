using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro14
{
    internal class Program
    {
        static void Main()
        {
            string name;

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            string revname = " ";
            int i;
            for (i = name.Length - 1; i >= 0; i--)
            {
                revname = revname + name[i];
            }
            if (name == revname)
            {
                Console.WriteLine("palidrom");
            }
            else
            {
                Console.WriteLine("not palidrom");
            }
        }
    }
}
