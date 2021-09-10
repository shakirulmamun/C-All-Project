using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__banking_part_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("========Saveing Account=========\n");
            SaveingAccount sv1 = new SaveingAccount();
            sv1.InterestAmount = 400;
            sv1.BankAccountNo = 083848;
            sv1.CustomerName = "Md. Shakirul Mamun";
            sv1.depositeAmount(1000);
            sv1.widthrow(300);
            double balance = sv1.Balance; 
            Console.WriteLine(balance);
            Console.ReadKey();


            Console.Write("========Checking Account=========\n");
            CheckingAccount ch = new CheckingAccount();
            ch.ServiceCharge = 100;
            ch.BankAccountNo = 837487;
            ch.CustomerName = "Sawon";
            ch.depositeAmount(5000);
            ch.widthrow(2000);
            double balance1 = ch.Balance;
            Console.WriteLine(balance1);
            Console.ReadKey();


            Console.Write("========Up Casting & Down Casting=========\n");
            BankAccount b1 = sv1;
            SaveingAccount sb2 = (SaveingAccount) b1;
            


        }
    }
    public class BankAccount
    {
        public int BankAccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        //public double ServiceCharge { get; set; } 
        //public double InterestAmount { get; set; } 

        public string depositeAmount (double amount)
        {
            Balance += amount;
            return "Deposite SuccessFully";
        }

        public string widthrow(double amount)
        {
            Balance -= amount;
            return "Widthrow SuccessFully";
        }
    }

    public class CheckingAccount:BankAccount
    {
        public double ServiceCharge { get; set; }
    }

    public class SaveingAccount:BankAccount
    {
        public double InterestAmount { get; set; }
    }
}
