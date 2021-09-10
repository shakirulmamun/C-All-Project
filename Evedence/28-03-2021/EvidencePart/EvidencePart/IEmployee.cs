using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePart
{
    interface IEmployee
    {
        decimal CalculateSalary(decimal basic, decimal medical, decimal overtime,
        decimal houseRent, decimal conveyence);
    }
}
