using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePart
{
    public sealed class Employee: Person, IEmployee, IRole

    {
        public string ID { get; set; }
        public Designations Designation { get; set; }
        public decimal Basic { get; set; }
        public decimal Medical { get; set; }
        public decimal HouseRent { get; set; }
        public decimal Conveyence { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Overtime { get; set; }
        public string[] RolePlays { get; set; }

        public decimal CalculateSalary(decimal basic, decimal medical, decimal overtime, decimal houseRent, decimal conveyence)
        {
            decimal grossPay = basic 
            + (basic * (medical / 100))
            + (basic * (houseRent / 100))
            + (basic * (conveyence / 100))
            +(((basic / 30) / 8) * 2 * overtime);
            return grossPay;

        }
        List<string> _roles = new List<string>();
        public void  AddRole(string Role)
        {
            _roles.Add(Role);
        }

        public string RolePlay()
        {
            return string.Join(",", _roles);
        }
    }
}
