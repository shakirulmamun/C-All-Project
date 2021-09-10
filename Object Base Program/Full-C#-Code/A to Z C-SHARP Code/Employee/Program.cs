using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\nID : ");
                string id = Console.ReadLine();
                Console.Write("\nFirst Name : ");
                string firstName = Console.ReadLine();
                Console.Write("\nLast Name : ");
                string lastName = Console.ReadLine();
                Console.Write("\nDate of Birth (dd/mm/yyyy): ");
                DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.Write("\nJoining Date: ");
                DateTime joiningDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nDesignation:\n====\n1. GM\n2. AGM\n3. DGM\n");
                Console.Write("\nPress any Number Above\n");
                int desig = Int32.Parse(Console.ReadLine());
                Employee em = new Employee(id, firstName, lastName, dateOfBirth, joiningDate, desig);
                Console.Write("\nGive role of the employee(seperate by comma [,])\n");
                string[] roles = em.GetRole(Console.ReadLine());
                Console.WriteLine("\n\nOutput=========\n\n");
                Console.WriteLine("\nEmployee ID: " + em.ID + "\nName:" + em.GetFullName() + "\nDate of Birth: "
                    + em.DateOfBirth.ToShortDateString() + "\nJoining Date: " + em.JoiningDate.ToShortDateString() +
                    "\nDesignation:" + em.Designation + "\nAge: " + em.GetAge() + "\nRole Plays:\n");
                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + "." + roles[i].Trim());
                }
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public abstract class person
    {
        public  string firstName = string.Empty;
        public string lastName = string.Empty;
        public DateTime DateOfBirth;
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime dateOfBirth { get; set; }
        public abstract string GetFullName();
        public abstract string GetAge();
    }

    public enum Designations
    {
        GM=1,
        AGM=2,
        DGM=3,
        Manager=4
    }

     interface IRole
    {
       string[] GetRole(string role);
    
    }

    public sealed class Employee: person,IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName=value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override DateTime dateOfBirth { get => dateOfBirth; set => dateOfBirth=value; }
        public DateTime JoiningDate { get; set; }
        public string Designation { get; set; }
        public Employee(string id, string firstName, string lastName, DateTime dateofBirth, DateTime joiningDate, int desig)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateofBirth;
            this.JoiningDate = joiningDate;
            this.Designation = Enum.GetName(typeof(Designations), desig);
        }

        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            int years =age.Days / 365;
            int months =(age.Days - years * 365) / 30;
            int days =(age.Days - years * 365 - months * 30);
            return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";
        }

        public override string GetFullName()
        {
            return FirstName+ " "+LastName;
        }
        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }

    }
     
}
