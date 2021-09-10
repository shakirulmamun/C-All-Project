using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
           Console.Write("Show Your Result: ");
           Console.WriteLine(Calculator(2, 3, 4));
           Console.ReadKey();
        }
        static int Calculator(int a, int b)
        {
            return (a + b);
        }
        static int Calculator(int a, int b,int c)
        {
            return (a + b + c);
        }
    }
}
