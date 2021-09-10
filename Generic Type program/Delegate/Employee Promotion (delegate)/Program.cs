using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Promotion__delegate_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> em = new List<Employee>();
            em.Add(new Employee() { Id = 100, Name = "Md. Shakirul", Salary = 30000, Experience = 3 });
            em.Add(new Employee() { Id = 101, Name = "Md. Sawon", Salary = 3000, Experience = 1 });
            em.Add(new Employee() { Id = 102, Name = "Md. Mukta", Salary = 35000, Experience = 5 });

            Employee.PromotionEmployee(em);
            Console.ReadKey();
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotionEmployee(List<Employee> emplist)
        {
            foreach (Employee emp in emplist)
            {
                if(emp.Experience >= 3)
                {
                    Console.WriteLine(emp.Name +" (PROMOTED) ");
                }
            }
        }
    }
}
