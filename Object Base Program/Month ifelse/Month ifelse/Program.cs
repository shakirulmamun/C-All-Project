using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;

            Console.Write("Input Month Duration : ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 30)
            {
                Console.WriteLine("April,June, August, November");

            }
            else if (month == 29)
            {
                Console.WriteLine("Jan,Feb,Mar,May,Jul");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadLine();
        }
    }
}
