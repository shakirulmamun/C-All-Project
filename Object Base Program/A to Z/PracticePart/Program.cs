using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePart
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1st Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2nd Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Your Operator (SUM,SUB,MUL,DIV,MOD) : ");
            string ope = Console.ReadLine();
            int res = Calculate(a, b, ope);
            Console.WriteLine("Total Result:" + res);
            Console.ReadKey();

        }   
       
        private static int Calculate(int a, int b, string ope)
        {
          try
          { 
            if(ope== "SUM")
            {
                return a+b;
            }
            else if(ope=="SUB")
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
            else if (ope == "MOD")
            {
                return a % b;
            }
            else
            {
                return 0;
            }
          }
          catch(Exception ex)
            {
                return ex.HResult;
            }
        }

        private static int Getprefix(int a, int b)
        {
            ++a;
            int c = a + b;
            return c;
            
        }
        private static int Getpostfix(int a, int b)
        {
           
            int c = a + b;
            a++;
            return c;

        }
    }
}
