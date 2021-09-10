using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region     // try,catch,finally

            int i = 0;
            int div = 0;
            try
            {
                div = 30 / i;
                Console.WriteLine("Not Execute");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.ReadKey();

            #endregion
        }
    }
}
