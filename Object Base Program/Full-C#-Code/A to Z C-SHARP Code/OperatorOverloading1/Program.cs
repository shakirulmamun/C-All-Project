using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading1
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 d = new Class1(33);
            Class1 d4 = new Class1(45);
            Class1 d5 = new Class1();
            d5 = d + d4;
            d.display();
            d4.display();
            Console.Write("Sum is: ");
            d5.display();
            Console.Read();
        }
    }
}
