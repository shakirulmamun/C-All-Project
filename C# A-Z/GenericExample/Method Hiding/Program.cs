using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            partTimeEmployee p = new partTimeEmployee();
            p.PrintFullName();

            ((Employee)p).PrintFullName();  //Cast ...(When need base class method print)
            Console.ReadKey();
        }
    }
    public class Employee       //Create Employee Class
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()   // Create PrintFullName Method
        {
            Console.WriteLine(FirstName + " " + LastName + " - Base class method");
        }
    }
    public class partTimeEmployee : Employee
    {
        public new void PrintFullName()  // Create PrintFullName Method with new keyword.......
            //Always base class method hide when inherit it...so output asbe child class method
        {
            // Console.WriteLine(FirstName + " " + LastName + " - Child class method");

            //when need base class method
            base.PrintFullName();
        }
    }
}
