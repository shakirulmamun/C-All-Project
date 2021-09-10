using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prefix
            /*int a = 10;

            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.ReadKey();*/

            //Postfix
            int a = 10;

            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.ReadKey();


            /*int a = 20;
            int b = 9;
            int c = 6;

            Console.WriteLine("The sum is = " + (a+b+c));                   //This is Addition
            Console.WriteLine("The Substruct is = " + (a-b-c));             //This is Subtraction
            Console.WriteLine("The Multiplication is = " + (a * b * c));    //This is Multiplication
            Console.WriteLine("The Division is = " + (a / b));                //This is Division
            Console.WriteLine("The Modulus is = " + (a % b));                //This is Modulus
            Console.ReadKey();*/
        }
    }
}
