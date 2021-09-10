using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void HelloDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate del = new HelloDelegate(Hello);
            del("Hello From Delegate...........");
            Console.ReadKey();
        }
        public static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }

    }
  

}
