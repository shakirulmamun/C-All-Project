using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 100; n=n+10)
            {
                if(n>80 && n<100)
                {
                    Console.WriteLine("Your result is pass");
                }
                else
                {
                    Console.WriteLine("Your result is fail");
                }
            }
            Console.ReadKey();
        }
    }
}
