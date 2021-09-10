using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount__Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount chk1 = new CheckingAccount();
            chk1.AccountNo = "019823373";
            chk1.CustomerName = "Md. Shakirul Mamun";
            chk1.ServiceCharge = 300;
            chk1.Deposit(5000);
            chk1.Withdraw(100);
            double Balance = chk1.Balance;
            Console.WriteLine("Balance : "+Balance);

            SaveingAccount sv1 = new SaveingAccount();
            sv1.AccountNo = "094848";
            sv1.CustomerName = "Sawon";
            sv1.Deposit(2000);
            sv1.Withdraw(100);
            double Balances = sv1.Balance;
            Console.WriteLine("Dsposit Balance : "+Balances);
            Console.ReadKey();
        }
       
    }
}
