using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = MyNumber(1, 2);   //Method Called
            Console.WriteLine(number1);
            double num2 = MyNumber(3.3, 2.40);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
        static int MyNumber(int a, int b)   //Method
        {
            return a + b;
        }
        static double MyNumber(double a, double b)      //Method Overloading
        {
            return a + b;
        }
    }
}
