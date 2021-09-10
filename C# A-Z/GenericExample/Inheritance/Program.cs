using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            fullTimeEmployee f = new fullTimeEmployee();
            f.FirstName = "Md. Shakirul";
            f.LastName = "Mamun";
            f.Email = "shakirulmamun@gmail.com";
            f.Age = 23;
            f.DateofBirth = "05-08-1996";
            f.Print();

            partTimeEmployee p = new partTimeEmployee();
            p.FirstName = "Md. Shakirul";
            p.LastName = "Mamun";
            p.Email = "shakirulmamun@gmail.com";
            Console.ReadKey();
        }
    }

    //C# Allows multi-level inheritance ....ai khane multilevel inheritance kora hoice
    //C# does not support multiple inheritance
    public class otherInfo 
    {
        public int Age;
        public string DateofBirth;
    }
    public class Employee: otherInfo
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void Print()
        {
            Console.WriteLine("Full Name & Email | Age|Date of Birth :{0} {1}|| {2}|{3} | {4} ", FirstName, LastName,Email,Age, DateofBirth);
        }
    }
    public class fullTimeEmployee:Employee
    {
        public float yearlySalary;
    }
    public class partTimeEmployee:Employee
    {
        public float hourlySalary;
    }
}
