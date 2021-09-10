using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
            Multiplication(ref x);
            Console.WriteLine("Variable Value After Calling the Method: {0}", x);
           // Console.WriteLine(x);
            Console.ReadKey();
        }
        public static void Multiplication(ref int a)
        {
            //a += a;
            a = 29;
            Console.WriteLine("Inside Method:", a);
        }
    }
}
