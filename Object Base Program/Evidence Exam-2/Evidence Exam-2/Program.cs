using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Exam_2
{
    class Program

    {
        static void Main(string[] args)

        {

            Console.Write("Employee ID\t: ");

            string ID = Console.ReadLine();

            Console.Write("Name\t: ");

            string Name = Console.ReadLine();

            Console.Write("Date of Birth\t: ");

            string dateOfBirth = Console.ReadLine();

            Console.Write("Designation { Programmer = 1, Manager = 2, CTO = 3, PD=4 }");

            string Designation = Console.ReadLine();

            Console.Write("Basic Salary\t: ");

            string Basic = Console.ReadLine();

            Console.Write("Medical(%)\t: ");

            string Medical = Console.ReadLine();

            //Console.Write("Conveyence(%)\t: ");

            //string Conveyence = Console.ReadLine();

            //Console.Write("HouseRent(%)\t: ");
            //string Houserent = Console.ReadLine();
            Employee emp = new Employee();

            emp.ID = Convert.ToInt32(ID);

            emp.Name = Name;

            emp.DoB = Convert.ToDateTime(dateOfBirth);

            emp.Designation = (Designations)Convert.ToInt32(Designation);

            emp.Basic = Convert.ToDecimal(Basic);

            emp.Medical = Convert.ToDecimal(Medical);

            emp.GrossPay = emp.CalculateSalary(emp.Basic, emp.Medical);

            string role = "";

            while (role.ToUpper() != "A")

            {

                Console.WriteLine("Role: [A to stop]");

                role = Console.ReadLine();

                if (role.ToUpper() != "A")

                {
                    emp.AddRole(role);
                }

            }

            Console.WriteLine();

            Console.WriteLine("=================================");

            Console.WriteLine($"ID\t\t: {emp.ID}");

            Console.WriteLine($"Name\t\t: {emp.Name}");

            Console.WriteLine($"Date of Birth\t: {emp.DoB.ToShortDateString()}");

            Console.WriteLine($"Designation\t: {emp.Designation}");

            Console.WriteLine($"Gross Pay\t: {emp.GrossPay}");

            Console.WriteLine($"Role Plays\t: {emp.RolePlay()}");

            Console.WriteLine("=================================");

            Console.ReadLine();

        }
    }
}
