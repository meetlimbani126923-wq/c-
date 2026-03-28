using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u4p2
{
    internal class vihical
    {
        string vihical_type;

        public void get_data()
        {
            Console.WriteLine("Enter vehical type --> ");
            vihical_type = Console.ReadLine();
        }

        public void show_vihical()
        {
            Console.WriteLine("Vehical Type --> " + vihical_type);
        }
    }
}
