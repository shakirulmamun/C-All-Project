using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Exam_2
{
    interface IEmployee

    {
        decimal CalculateSalary(decimal basic, decimal medical,
        decimal houseRent=5, decimal conveyence=20);
    }
}
