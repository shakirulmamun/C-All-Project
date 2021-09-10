using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            doSalary2();
            Console.ReadKey();
        }


        static void doSalary2()
        {
            Console.WriteLine("input gross salary");
            var gs = Console.ReadLine();
            Salary s = new Salary();
            var gsReturn = s.CalculateByGrossSalary(Convert.ToInt32(gs));
            Console.WriteLine(">> Basic Salary:         {0}/= {1}", s.basicSalary, s.currency);
            Console.WriteLine(">> House Rent:           {0}/= {1}", s.houseRent, s.currency);
            Console.WriteLine(">> Medical Allowance:    {0}/= {1}", s.medicalAllowance, s.currency);
            Console.WriteLine(">> Conveyance Allowance: {0}/= {1}", s.conveyanceAllowance, s.currency);
            Console.WriteLine("......................................");
            Console.WriteLine("   Gross Salary:         {0}/= {1}", gsReturn, s.currency);
            Console.WriteLine("   Basic Salary:         {0}/= {1}", gsReturn, s.currency);
        }
    }
}

