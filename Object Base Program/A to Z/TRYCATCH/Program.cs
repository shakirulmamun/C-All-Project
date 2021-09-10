using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYCATCH
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int div = 0;
            try
            {
                div = 100 / i;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div}");
            Console.ReadKey();

        }

    }
}
