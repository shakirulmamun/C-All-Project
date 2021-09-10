using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method_And_Variable
{
    class Program
    {
        class Number
        {
            public static int num;  //static varibale
            public static void power()
            {
                Console.WriteLine("Power of {0} = {1}", num, num * num);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number:\t");
            Number.num = Convert.ToInt32(Console.ReadLine());
            Number.power();
            Console.ReadKey();
        }
    }
}
