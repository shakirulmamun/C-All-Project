using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Your Operator: SUM,SUB,MUL,DIV,MODU");
            string ope = Console.ReadLine();
            int res = Caltulator(a, b, ope);
            Console.WriteLine("Total Result is: "+res);
            Console.ReadKey();


        }
        private static int Caltulator(int a, int b, string ope)
        {
            if (ope == "SUM")
            {
                return a + b;
            }
            else if (ope == "SUB")
            {
                return a - b;
            }
            else if (ope == "MUL")
            {
                return a * b;
            }
            else if (ope == "DIV")
            {
                return a / b;
            }
            else if (ope == "MODU")
            {
                return a % b;
            }
            else
            {
                return 0;
            }

        }
            
}
}
