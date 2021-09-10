using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_to_Z_C_SHARP_Code
{
    class Program
    {
        //public static int result = 0; // global scope available in other class also
        //static int n = 0;
        static void Main(string[] args)
        {
            //#region    // for loop............
            //Console.WriteLine("for...loop.............");
            //for (int i = 0; i <= 100; i += 10)
            //{
            //    if (i > 80 && i <= 100)

            //    {

            //        Console.WriteLine("You are pass");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are fail");
            //    }
            //}
            //Console.ReadKey();
            //#endregion

            //#region //do ....while loop.........
            //Console.WriteLine("do...While loop.............");
            //int k = 0;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}
            //while (k < 10);
            //Console.ReadKey();
            //#endregion

            //#region   //while .....loop
            //Console.WriteLine("While...loop.............");
            //int m = 0;
            //while (m < 10)
            //{

            //    Console.WriteLine(m);
            //    m++;
            //}
            //Console.ReadKey();

            //#endregion

            //#region....//Switch case .............
            //Console.WriteLine("Switch case.............\n");
            //int day = 7;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Sat");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sun");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mon");
            //        break;
            //    case 4:
            //        Console.WriteLine("Tu");
            //        break;
            //    case 5:
            //        Console.WriteLine("Wed");
            //        break;
            //    case 6:
            //        Console.WriteLine("Th");
            //        break;
            //    case 7:
            //        Console.WriteLine("Fri");
            //        break;
            //}
            //Console.ReadKey();

            //#endregion

            //#region  // if..else..............
            //Console.WriteLine("if else.............");
            //Console.WriteLine("Enter your chosen number : ");
            //int result = Convert.ToInt32(Console.ReadLine());
            //if (result >= 80 && result < 100)
            //{
            //    Console.WriteLine("Your result is: A+");
            //}
            //else if (result >= 70 && result < 79)
            //{
            //    Console.WriteLine("Your result is: A");
            //}
            //else if (result >= 60 && result < 69)
            //{
            //    Console.WriteLine("Your result is: A-");
            //}
            //else if (result >= 50 && result < 59)
            //{
            //    Console.WriteLine("Your result is: B");
            //}
            //else if (result >= 40 && result < 49)
            //{
            //    Console.WriteLine("Your result is: C");
            //}
            //else if (result >= 33 && result < 39)
            //{
            //    Console.WriteLine("Your result is: D");
            //}
            //else
            //{
            //    Console.WriteLine("Your result is: Fail");
            //}
            //Console.ReadKey();
            //#endregion

            //#region   //foreach..................
            //Console.WriteLine("foreach.............");
            //string[] Books = new string[] { "Math", "English", "Bangla", "C#" };      //array declare
            //foreach (string book in Books)          //use foreach
            //{
            //    Console.WriteLine(book);          //call
            //}
            //Console.ReadKey();
            //#endregion

            //#region   // variable assigning and call.......
            //Console.WriteLine("Variable.............");

            //int y = 9;          //variable assign
            //int z = 30;
            //int c = y + z;
            //Console.WriteLine(c);           //variable call
            //Console.ReadKey();
            //#endregion

            //#region  // Using Mathmatical Operator.............
            //Console.WriteLine("Using Mathmatical Operator.............");
            //Console.WriteLine("Enter your 1st Number: ");
            //int p = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Select your Operator: ( +,-,*,/,%) ");
            //string ope = Console.ReadLine();
            //Console.WriteLine("Enter your 2nd Number: ");
            //int q = Convert.ToInt32(Console.ReadLine());

            //int answer;
            ////int p = 9;          
            ////int q = 30;
            //if (ope == "+")
            //{
            //    answer = p + q;
            //    Console.WriteLine("Sum: " + answer);
            //}
            //else if (ope == "-")
            //{
            //    answer = p - q;
            //    Console.WriteLine("Substruction: " + answer);
            //}
            //else if (ope == "*")
            //{
            //    answer = p * q;
            //    Console.WriteLine("Multipication: " + answer);
            //}
            //else if (ope == "/")
            //{
            //    answer = p / q;
            //    Console.WriteLine("Division: " + answer);
            //}
            //else if (ope == "%")
            //{
            //    answer = p % q;
            //    Console.WriteLine("Modulus: " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("!opps your enter number is invalid");
            //}
            //Console.ReadKey();
            //#endregion

            //#region   //Prefix
            ////Console.WriteLine("\nPrefix..........");
            ////for (int i = 0; i < 5; ++i)
            ////{
            ////    Console.WriteLine(i);
            ////}
            ////int a = 10;
            ////Console.WriteLine(a);
            ////Console.WriteLine(++a);
            ////Console.WriteLine(a);
            ////Console.ReadKey();
            //#endregion

            //#region   //Postfix
            ////Console.WriteLine("\nPostfix..........");
            ////for (int i = 0; i < 5; i=i++)
            ////{
            ////    Console.WriteLine(i);
            ////}
            ////int a = 10;
            ////Console.WriteLine(a);
            ////Console.WriteLine(a++);
            ////Console.WriteLine(a);
            ////Console.ReadKey();
            ////#endregion

            //#endregion
            #region
            //TotalNumber(12, 2);
            //Console.WriteLine(TotalNumber(12, 2));
            //TotalNumber(12, 2, 3);
            //Console.WriteLine(TotalNumber(12, 2, 3));
            //Console.ReadKey();

            //Method, scope, parameter,optional parameter and named agruments
            //Console.WriteLine("\n\n1st Student Details: \n");
            //StudentInfo("Md.Shakirul", "Mamun");        //name agruments
            //Console.WriteLine("\n\n2nd Student Details: \n");
            //StudentInfo("Mukta", "Moni", 30);
            //Console.WriteLine("\n\n3rd Student Details: \n");
            //StudentInfo("Riya", "Khan", 37, "Information Technology");
            //Console.ReadKey();

            //#region   //try,catch,finally
            //int s = 0;
            //int div = 0;
            //try
            //{
            //    div = 20 / s;
            //    Console.WriteLine("Not Execute");
            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("Exception occured");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block");
            //}
            //Console.ReadKey();
            //#endregion

            #region         //array

            string[] names = new string[4];
            names[0] = "Rafi";
            names[1] = "Mamun";
            names[2] = "Sajib";
            names[3] = "Karim";
            Console.WriteLine(names[0]);
            Console.ReadKey();

            #endregion

            ArrayList(names);
            Console.ReadKey();





        }
        static void ArrayList(string[]names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }




        //static double TotalNumber(double firstNumber, double secondNumber)  //Method with parameter
        //{

        //    {
        //        return firstNumber + secondNumber;
        //    }


        //}
        //static double TotalNumber(double firstNumber, double secondNumber, double thirdNumber)      //Method overloading
        //{

        //    {
        //        return firstNumber + secondNumber + thirdNumber;
        //    }
        //}
        #endregion
        //public static void StudentInfo(string firstname, string lastname, int age = 20, string Dept = "Computer science")
        ////firstname, lastname & age is mandatory parameter and Dept is optional parameter

        //{
        //    Console.WriteLine("First name: {0}", firstname);
        //    Console.WriteLine("Last name: {0}", lastname);
        //    Console.WriteLine("Age: {0}", age);
        //    Console.WriteLine("Dept: {0}", Dept);
        //}
    }
}

