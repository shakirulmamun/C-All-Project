using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Project
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

            Console.Write("Overtime: ");

            string overtime = Console.ReadLine();

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

            emp.Overtime = Convert.ToDecimal(overtime);

            emp.GrossPay = emp.CalculateSalary(emp.Basic, emp.Medical,emp.Overtime);

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

    public abstract class person
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
    }
   public enum Designations
    {
        Programmer=1,
        CTO=2,
        PD=3
    }

    public interface IRole
    {
        void AddRole(string Role);
        string RolePlay();
    }

    interface IEmployee
    {
        decimal CalculateSalary(decimal basic, decimal medical, decimal overtime, decimal houseRent = 5, decimal
            conveyence = 20);
    }

   public sealed class Employee:person, IEmployee,IRole

   {
        public int ID { get; set; }
        public Designations Designation { get; set; }
        public decimal Basic { get; set; }
        public decimal Medical { get; set; }
        public decimal HouseRent { get; set; }
        public decimal Conveyence { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Overtime { get; set; }
        public string[] RolePlays { get; set; }
        public decimal CalculateSalary(decimal basic, decimal medical, decimal overtime, decimal houseRent = 5, decimal conveyence = 20)
        {
            decimal grossPay = basic + (basic * (medical / 100))
                        + (basic * (houseRent / 100))
                        + (basic * (conveyence / 100))
                         + (((basic / 30) / 8) * 2 * overtime);
            return grossPay;
        }

        List<string> _roles = new List<string>();
        public void AddRole(string Role)
        {
            _roles.Add(Role);

        }
        public string RolePlay()
        {
            return string.Join(",", _roles);
        }
    }

}
