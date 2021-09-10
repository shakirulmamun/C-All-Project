using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Delegate
{

    //must be same Delegate Method type, and parameter and Creating Method type, and parameter
    public delegate int CalculateHandelar(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(); //instance create

            //CalculateHandelar cl = Add; // Delegate attach Add Method
            CalculateHandelar cl = new CalculateHandelar(Add);  // Delegate attach Add Method
            int resul=cl.Invoke(3,4);
            Console.WriteLine(resul);
            Console.ReadKey();
            
        }

         static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
