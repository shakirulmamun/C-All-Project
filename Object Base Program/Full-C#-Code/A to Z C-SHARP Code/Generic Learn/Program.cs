using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator.AreEqual<int>(2, 2);
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadKey();
        }
    }
}
