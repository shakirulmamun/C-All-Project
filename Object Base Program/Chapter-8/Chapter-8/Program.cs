using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 3000;
            Caltulate(ref salary);
            Console.WriteLine(salary);
            int tax;
            Tax(out tax);
            Console.WriteLine(salary - tax);
            Console.ReadKey();

        }
        static void Caltulate(ref int salary)
        {
            int bonous = 1100;
            salary = bonous + salary;
        }
        static void Tax(out int tax)    //out is value type
        {
            tax = 200;
        }
    }
}
