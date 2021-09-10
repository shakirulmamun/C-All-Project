using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int, int> Calculate = Add;   //Method call in Action delegate
           
            //Use Anounimous Method & lamda Expression 
            Action<int, int> Calculate = (int num1, int num2) => Console.WriteLine(num1 + num2);
           
            Calculate.Invoke(3, 4);
            Console.ReadKey();
        }
        public static void Add(int num1, int num2)      //no return
        {
            int result = num1 + num2;
            Console.WriteLine("Sum: "+result);
        }
    }
}
