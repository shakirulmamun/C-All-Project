using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass(); //Instance create base class but show derived class mehtod it's overriding and method hiding
            B.Print();
            Console.ReadKey();
        }
    }
    public class BaseClass
    {
        public virtual void Print()     //Base Class Virtual Method
        {
            Console.WriteLine("Base Class Method");
        }
    }
    public class DerivedClass : BaseClass   //inherit base Class 
    {
        public override void Print()        //override print Method
        {
            Console.WriteLine("Derived Class Method");
        }
    }
}
