using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount__Inheritance_
{
    class BankAccount
    {
        /// <summary>
        /// BankAccount class has 3 property and 2 Method Deposit,Withdraw with Parameter
        /// </summary>
        public string AccountNo {set;get;}      
        public string CustomerName { set; get; }
        public double Balance { set; get; }

        public string Deposit (double amount)
        {
            Balance += amount;
            return "Deposited";
        }
        public string Withdraw (double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }
    }
}
