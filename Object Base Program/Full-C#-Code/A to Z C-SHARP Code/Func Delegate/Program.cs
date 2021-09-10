using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> Calculate = Add;  //normal method attach 

            Func<int, int, int> Calculate = (int num1, int num2) => num1 + num2;//lamda expression use korea anounimous method lika

            //Func<int> Calculate = () => 10; //only return without input parameter
            
            int result = Calculate.Invoke(12, 23);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
