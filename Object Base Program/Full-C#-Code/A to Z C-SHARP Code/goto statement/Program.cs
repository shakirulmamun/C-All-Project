using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    goto endloop;
                }
                Console.WriteLine(i);
            }
            endloop: Console.WriteLine("The end");

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();
        }
    }
}
