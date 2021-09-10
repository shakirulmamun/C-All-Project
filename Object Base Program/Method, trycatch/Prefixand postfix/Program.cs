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
            Console.WriteLine("Enter Your choose number: ");
            int i= Convert.ToInt32(Console.ReadLine());


            try
            {
                if (i >= 80 && i < 100)
                {
                    Console.WriteLine("Your result is : A+");
                }
                else if (i >= 70 && i < 79)
                {
                    Console.WriteLine("Your result is : A");
                }
                else if (i >= 60 && i < 69)
                {
                    Console.WriteLine("Your result is : A");
                }
                else if (i >= 50 && i < 59)
                {
                    Console.WriteLine("Your result is : B");
                }
                else if (i >= 40 && i < 49)
                {
                    Console.WriteLine("Your result is : C");
                }
                else if (i >= 33 && i < 39)
                {
                    Console.WriteLine("Your result is : D");
                }
                //else
                //{
                //    Console.WriteLine("Your result is : F");
                //}
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
