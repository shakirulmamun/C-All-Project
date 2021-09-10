using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount__Inheritance_
{
    class CheckingAccount: BankAccount  //Derive class inherite base class
    {
        /// <summary>
        /// CheckingAccount has only one property (ServiceCharge)
        /// </summary>
        public double ServiceCharge { set; get; }
    }
}
