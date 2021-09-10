using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @return
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = SumofNumbers(20, 28);
            //Console.WriteLine(result);
            //result = SumofNumbers(i, j);
            //Console.WriteLine(result);


                int i = 10, j = 20, result = 0;

                result = SumofNumbers(i, j);

                Console.WriteLine("Result: {0}", result);

                Console.WriteLine("Press Enter Key to Exit..");

                Console.ReadLine();

       

            Console.ReadKey();
        }
        public static int SumofNumbers(int a, int b)
        {
            int x = a + b;
            return x;
        }
    }
}
