using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount__Inheritance_
{

    class SaveingAccount:BankAccount    //Derive class inherite base class
    {
        /// <summary>
        /// SaveingAccount has 1 property (InterestAmount)
        /// </summary>
        public double InterestAmount { set; get; }
    }
}
