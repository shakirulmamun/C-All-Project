using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Multiplication(out x);
            Console.WriteLine("Variable Value: {0}", x);
            Console.ReadKey();
        }
        public static void Multiplication(out int a)
        {
            a = 10;
            a *= a;
           
        }
    }
}
