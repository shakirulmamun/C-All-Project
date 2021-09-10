using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            do
            {
                Console.WriteLine(i);
                i = i + 4;
            }
            while (i <= 100);
            Console.ReadKey();
        }
    }
}
