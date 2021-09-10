using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Enceptulation_
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            Console.WriteLine(em.getexp());
            em.Salary = 15000;
            Console.WriteLine(em.Salary);
            Console.ReadKey();
        }
    }
}
