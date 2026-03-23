using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_
{
    internal class details
    {
        int eid;
        int econ;
        string ename;

        public void emp_details()
        {
            Console.WriteLine(" enter Employee name ");
            ename = Console.ReadLine();

            Console.WriteLine(" enter Employee contact number ");
            econ = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(" enter employee id ");
            eid = Convert.ToInt32(Console.ReadLine());
        
        }
        public void display()
        {
            Console.WriteLine(" enter empioyee name" + ename );
            Console.WriteLine(" enter employee contact number" + econ );
            Console.WriteLine(" enter employee id" + eid );

                
        }
    }
}
