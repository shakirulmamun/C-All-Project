using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
       
        static void Main(string[] args)
        {
            studentInfo("Md. Shakirul", "Mamun",33);
            //studentInfo("Md. Shakirul", "Mamun", 30);
            studentInfo("Md. Mamun", "Khan",30,"CSE");
            //TotalNumber(10.5, 20.09);
            //Console.WriteLine(TotalNumber(10.5, 20.09));

            //TotalNumber(10.5, 20.09, 20.09);
            //Console.WriteLine(TotalNumber(10.5, 20.09, 20.09));
            Console.ReadKey();
        }
        static void studentInfo(string firstName, string lastName, int age, string dept="Computer Science")
        {
            Console.WriteLine("FirstName: {0}" ,firstName);
            Console.WriteLine("LastName:{0}", lastName);
            Console.WriteLine("Age:{0}", age);
            Console.WriteLine("Dept:{0}", dept);
        }
        //static double TotalNumber(double firstNumber, double secondNumber)
        //{

        //    {
        //        return firstNumber + secondNumber;
        //    }


        //}
        //static double TotalNumber(double firstNumber, double secondNumber, double thirdNumber)
        //{

        //    {
        //        return firstNumber + secondNumber + thirdNumber;
        //    }

        //}
    }
}
