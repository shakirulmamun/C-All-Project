using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int i;
            for ( i = 0;  i <= 110;  i=i+10)
            {
                if (i >= 80 && i <= 100)
                {
                    Console.WriteLine("Your Result is : A+");
                }
                else
                {
                    Console.WriteLine("Default");
                }
            }

        }
    }
}
