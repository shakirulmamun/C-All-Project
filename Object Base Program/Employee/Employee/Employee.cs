using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public sealed class Employee : Person, IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override DateTime dateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Designation { get; set; }
        public Employee(string id, string firstName, string lastName, DateTime dateOfBirth, int desig)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Designation = Enum.GetName(typeof(Designation), desig);
        }
        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            int years = age.Days / 365;
            int months = (age.Days - years * 365) / 30;
            int days = (age.Days - years * 365 - months * 30);
            return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";
        }
        public override string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }
    }
}
