using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Valid Input: ");
            int gradeResult = Convert.ToInt32(Console.ReadLine());

            if (gradeResult >= 80 && gradeResult <= 100)
            {
                Console.WriteLine("Your Result is: A+");
            }
            else if (gradeResult >= 70 && gradeResult <=79)
            {
                Console.WriteLine("Your Result is: A");
            }
            else if (gradeResult >= 60 && gradeResult <= 69)
            {
                Console.WriteLine("Your Result is: A-");
            }
            else if (gradeResult >= 50 && gradeResult <= 59)
            {
                Console.WriteLine("Your Result is: B");
            }
            else if (gradeResult >= 40 && gradeResult <= 49)
            {
                Console.WriteLine("Your Result is: C");
            }
            else if (gradeResult >= 39 && gradeResult <=33 )
            {
                Console.WriteLine("Your Result is: D");
            }
            else
            {
                Console.WriteLine("Your Result is: Fail\n\n\n");
            }
            Console.WriteLine("Press any key to exist.................");
            Console.ReadKey();
        }
    }
}
