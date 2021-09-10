using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDelegate
{
    delegate bool IsPromotable(Employee emp);
    class Program
    {
        public static bool Promote(Employee emp)
        {
            return emp.Experience >= 3 ? true : false;
        }
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { Id = 1, Name = "Md. Shakirul", Salary = 3000, Experience = 4});
            employees.Add(new Employee() { Id = 2, Name = "Mamun", Salary = 20000, Experience = 5 });


            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(employees, isPromotable);
            Console.ReadKey();
        }
        
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> emplist, IsPromotable isPromotable)
        {
            foreach (Employee emp in emplist)
            {
                if (isPromotable(emp))
                {
                    Console.WriteLine("\n======Promoted Employee List=======");
                    Console.WriteLine(emp.Name + " "+ "Promoted");
                }
            }
        }
    }
}
