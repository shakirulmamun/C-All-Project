using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    public delegate void PrintHandler(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //Method calling way

            //PrintHandler printhandler = Hello; //Hello Method Add/Attach in Delegate Method
            //printhandler += GoodBye;        //GoodBye Method Add/Attach in Delegate Method
            ////printhandler -= GoodBye;  //GoodBye Method Remove in Delegate Method
            //printhandler("MD. Shakirul Mamun");

            //Invoke way Method calling 

            PrintHandler p = Hello;
            PrintHandler p1 = GoodBye;      //p1 new reference
            PrintHandler p2 = p + p1;       //p2 new reference
            p2.Invoke("Md. Shakirul Mamun");  // Invoke means Call houya/kora
            Console.WriteLine("===================");
            Console.WriteLine("===================");

            p2 -= p;    //Hello Method remove
            p2.Invoke("Sawon"); //Print GoodBye Method
            Console.ReadKey();
        }

         public static void Hello(string name)
        {
            Console.WriteLine("Hello: " +name);
        }
        public static void GoodBye(string name)
        {
            Console.WriteLine("GoodBye: " + name);
        }
    }
}
