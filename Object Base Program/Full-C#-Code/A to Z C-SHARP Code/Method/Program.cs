using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        //#region  //Method
        //class Calculation
        //{
        //    public static int num1, num2, result;  //static field/variable
        //    public static void Sumation()       //static method
        //    {
        //        //jokon user input neya hoy tokon must oi field takea convert kortea hoy
        //        Console.Write("Enter your first Number:\t");
        //        num1 = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("Enter your second Number:\t");
        //        num2 = Convert.ToInt32(Console.ReadLine());
        //        result = num1 + num2;
        //        Console.Write("\nSum = {0}", result);
        //    }

        //}
        //#endregion

        static void Main(string[] args)
        {
            //Sumation Method calling

            //Calculation.Sumation();  //static method a kono instance/object create kortea hoy na 
            //                         //sudu method call korleai hoy
            //Console.ReadKey();



            // Info & PrintDetails method call

            Details d = new Details();
            d.Info();               //info method calling
            d.PrintDetails();       //PrinDetails method calling
            Console.ReadLine();
            Console.ReadKey();
        }

        class Details
        {
            string Name, City;
            int Age;
            public void Info()
            {
                Console.Write("Enter your Name:\t");
                Name = Console.ReadLine();

                Console.Write("\nEnter your City Name:\t");
                City = Console.ReadLine();

                Console.Write("\nEnter your Age:\t");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            public void PrintDetails()
            {
                Console.Write("\n=================\n");
                Console.WriteLine("Name:"+Name);
                Console.WriteLine("City:" + City);
                Console.WriteLine("Age:" + Age);
                Console.WriteLine(".......... This is Method Calling Way............");
            }
        }
    }
}
