using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Exam_2
{
    public sealed class Employee : Person, IEmployee, IRole

    {
        public int ID { get; set; }
        public Designations Designation { get; set; }
        public decimal Basic { get; set; }
        public decimal Medical { get; set; }
        public decimal HouseRent { get; set; }
        public decimal Conveyence { get; set; }
        public decimal GrossPay { get; set; }
        public string[] RolePlays { get; set; }
        public decimal CalculateSalary(decimal basic, decimal medical, decimal houseRent=5, decimal conveyence=20)

        {

            decimal grossPay = basic
                
                + (basic * (medical / 100))

                + (basic * (houseRent / 100))

                + (basic * (conveyence / 100));

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
