using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate__with_Lamda_Expression_
{
    delegate bool IsPromotable(Employee emp);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 1, Name = "Md. Shakirul", Salary = 12000, Experience = 4 });
            empList.Add(new Employee() { Id = 2, Name = "Md. Sawon", Salary = 12000, Experience = 2 });
            empList.Add(new Employee() { Id = 3, Name = "Md. Mukta", Salary = 13000, Experience = 1 });
            empList.Add(new Employee() { Id = 4, Name = "Md. Mahin", Salary = 14000, Experience = 5 });
            empList.Add(new Employee() { Id = 5, Name = "Md. Tuhin", Salary = 15000, Experience = 6 });


            Employee.PromotEmployee(empList, emp => emp.Experience >3);
            Console.ReadKey();

        }


    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotEmployee(List<Employee> emplist, IsPromotable isPromotable)
        {
            foreach (Employee emp in emplist)
            {
                if (isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + "Promoted");
                }
            }
        }
    }
}
