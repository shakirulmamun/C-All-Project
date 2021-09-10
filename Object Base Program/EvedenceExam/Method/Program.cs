using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        public static int result = 0; // global scope available in other class also
        static int n = 0;
        static void Main(string[] args)
        {
            // Calling the StudentInfo method 
            Console.WriteLine("\n\n1st Student Details: ");
            StudentInfo("Md.Shakirul", "Mamun");        //name agruments
            Console.WriteLine("\n\n2nd Student Details: ");
            StudentInfo("Mukta", "Moni", 30);
            Console.WriteLine("\n\n3rd Student Details: ");
            StudentInfo("Riya", "Khan", 37,
            "Information Technology");
            DoSum(2, 3);
            Console.WriteLine(result);
            Console.ReadKey();


        }
        static void DoSum(int num1, int num2) // method
        {
            int total = num1 + num2; // total is local scope variable
            result = total;
            Console.WriteLine("{0} + {1}", num1, num2, total);

        }

        public static void StudentInfo(string firstname, string lastname, int age = 20, string Dept = "Computer science")
            //firstname, lastname, age is mandatory parameter and Dept is optional parameter

        {
            Console.WriteLine("First name: {0}", firstname);
            Console.WriteLine("Last name: {0}", lastname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Branch: {0}", Dept);
        }
       
    }
}
