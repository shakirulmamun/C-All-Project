using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class Program
    {
        static void Main(string[] args)
        {
            //int integer = 1;
            //string ourString = "Something to be replaced by an int";
            //ourString = integer.ToString();
            //System.Console.WriteLine(ourString);
           


            int x = 1, y = 2;
            int sum = x + y;
            string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
            Console.WriteLine(sumCalculation);
            Console.ReadKey();
        }
    }
}
