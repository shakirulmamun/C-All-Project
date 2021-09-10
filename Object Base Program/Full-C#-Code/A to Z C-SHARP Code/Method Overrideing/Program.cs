using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overrideing
{
    class Program
    {
        static void Main(string[] args)
        {
            //SaveingAccount part
            //SaveingAccount sv = new SaveingAccount();
            //sv.BankAccountNo = 93849484;
            //sv.CoustomerName = "Md. Shakirul Mamun";
            //sv.InterestAmount = 479;
            //Console.WriteLine(sv.depositeAmount(amount: 1000));
            //Console.WriteLine(sv.widthrowAmount(amount: 3000));
            //double balance = sv.Balance;
            ////Console.WriteLine(balance);
            //Console.ReadKey();

            //CheckingAccount Part
            CheckingAccount ck = new CheckingAccount();
            ck.BankAccountNo = 4748474;
            ck.CoustomerName = "Sawon";
            ck.ServiceCharge = 300;
            Console.WriteLine(ck.depositeAmount(3000));
            Console.WriteLine(ck.widthrowAmount(7000));
            Console.ReadKey();
        }
    }
    public class BankAccount
    {
        public int BankAccountNo { get; set; }
        public string CoustomerName { get; set; }
        public double Balance { get; set; }
        //public int SaveingAccount { get; set; }
        //public int CheckingAccount { get; set; }

        public string depositeAmount(double amount)
        {
            Balance += amount;
            return "Deposite SuccessFull";
        }

        public virtual string widthrowAmount(double amount)
        {

            Balance -= amount;
            return "Insuficiant Balance";
        }
    }

    public class SaveingAccount:BankAccount
    {
        public double InterestAmount { get; set; }

        public override string widthrowAmount(double amount)
        {
            if (Balance >= amount)
            {
                return base.widthrowAmount(amount);
            }
            return "Insuficiant Balance";
        }

    }
    public class CheckingAccount:BankAccount
    {
        public double ServiceCharge { get; set; }
    }
}
