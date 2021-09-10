using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestingMethod
{
    class Program
    {
       
        class nesting
        {
            public void getSum(int m, int n)
            {
                int large = max(m, n);
                Console.WriteLine(large);
                int max(int a, int b)
                {
                    int x = (a + b);
                    return (x);
                }

            }
        }
        class nestTest
        {
            static void Main(string[] args)
            {
                nesting ns = new nesting();     //Instance Class
                ns.getSum(2, 5);
                Console.ReadKey();
            }
        }
    }
}
