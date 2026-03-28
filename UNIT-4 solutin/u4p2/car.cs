using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u4p2
{
    internal class car:vihical
    {
        string model_type, compny_name;

        public void get_car()
        {
            Console.WriteLine("Enter car type --> ");
            model_type = Console.ReadLine();

            Console.WriteLine("Enter compny name --> ");
            compny_name = Console.ReadLine();
        }

        public void show_car()
        {
            Console.WriteLine("Car type -->   " + model_type);
            Console.WriteLine("Car compny --> " + compny_name);
        }
    }
}
