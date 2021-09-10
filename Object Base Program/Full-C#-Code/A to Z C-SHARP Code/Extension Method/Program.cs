using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 1000;
            int j = 300;
            bool result = i.IsGreaterThan(100);
            bool result1 = j.IsGreaterThan(500);

            Console.WriteLine("Result1 is: "+ result);
            Console.WriteLine("Result2 is: " + result1);
            Console.ReadKey();
        }
    }

    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
