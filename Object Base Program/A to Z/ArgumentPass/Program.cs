using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentPass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the scholar method 
            StudentInfo("Md.Shakirul", "Mamun");
            StudentInfo("Siya", "Joshi", 30);
            StudentInfo("Rohan", "Joshi", 37,
            "Information Technology");
            Console.ReadKey();


        }
        static public void StudentInfo(string fname, string lname, int age = 20, string branch = "Computer science")

        {
            Console.WriteLine("First name: {0}", fname);
            Console.WriteLine("Last name: {0}", lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Branch: {0}", branch);
        }
    }
}
