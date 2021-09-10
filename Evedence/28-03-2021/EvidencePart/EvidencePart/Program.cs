using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Employee ID: ");
            string ID = Console.ReadLine();
            Console.Write("Employee Name: ");
            string Name = Console.ReadLine();
            Console.Write("Date of Birth: (dd/mm/yyyy) ");
            string DoB = Console.ReadLine();
            Console.WriteLine("Designations:\n DGM = 1\n AGM = 2\n GM = 3\n Please select above any number");
            string Designation = Console.ReadLine();
            
            Console.Write("Basic Salary\t: ");

            string Basic = Console.ReadLine();

            Console.Write("Medical(%)\t: ");

            string Medical = Console.ReadLine();

            Console.Write("HouseRent(%)\t: ");

            string HouseRent = Console.ReadLine();

            Console.Write("Conveyence(%)\t: ");

            string Conveyence = Console.ReadLine();

            Console.Write("Overtime: ");

            string overtime = Console.ReadLine();

            Employee em = new Employee();

            em.ID = Convert.ToString(ID);

            em.Name = Name;
            em.DoB = Convert.ToDateTime(DoB);
            em.Designation = (Designations)Convert.ToInt32(Designation);
            em.Basic = Convert.ToDecimal(Basic);
            em.Medical = Convert.ToDecimal(Medical);
            em.HouseRent = Convert.ToDecimal(HouseRent);
            em.Conveyence = Convert.ToDecimal(Conveyence);
            em.Overtime = Convert.ToDecimal(overtime);
            em.GrossPay = em.CalculateSalary(em.Basic, em.Medical,em.HouseRent,em.Conveyence,em.Overtime);
            
            string role = "";

            while (role.ToUpper() != "A")

            {

                Console.Write("Role:[A/a Stop this]\n ");
                role = Console.ReadLine();
                

                if (role.ToUpper() != "A")

                {
                    em.AddRole(role);
                }

            }

            Console.WriteLine();
            Console.WriteLine("=============");
            Console.WriteLine($"ID\t\t:{em.ID}");
            Console.WriteLine($"Name\t\t:{em.Name}");
            Console.WriteLine($"Date of Birth\t: {em.DoB.ToShortDateString()}");

            Console.WriteLine($"Designation\t: {em.Designation}");
           
            Console.WriteLine($"Over Time\t: {em.Overtime}");

            Console.WriteLine($"Gross Pay\t: {em.GrossPay}");

            Console.WriteLine($"Role Plays\t: {em.RolePlay()}");

            Console.WriteLine("=================================");
            Console.WriteLine("Thanks for providing your Details");

            Console.ReadLine();

            

        }
    }
}
