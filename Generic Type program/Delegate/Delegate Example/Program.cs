using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
{
    public delegate void DelegateName(string strMsg);   //create delegate
    class Program
    {
        static void Main(string[] args)
        {
            DelegateName del = new DelegateName(Hello); //object + constructor+ parameter name holo method name
            del("Message");
            Console.ReadKey();
        }
        public static void Hello(string strMsg)     // method but same as delegate
        {
            Console.WriteLine(strMsg);

        }
        
    }
}
