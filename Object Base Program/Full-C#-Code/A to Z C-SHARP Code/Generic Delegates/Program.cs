using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates
{
    delegate void PrintHandler<T>(T param);
    class Program
    {
        static void Main(string[] args)
        {
            PrintHandler <string> p = Hello;
             p += GoodBye;
            p.Invoke("Md. Shakirul");
            PrintHandler<int> p1 = Add;
            p1.Invoke(40);
            Console.ReadKey();
        }


        public static void Add(int num)
        {
            Console.WriteLine("Result: "+num);
        }
        public static void Hello (string name)
        {
            Console.WriteLine("Hello: " + name);
        }
        public static void GoodBye(string name)
        {
            Console.WriteLine("GoodBye: " + name);
        }
    }
}
