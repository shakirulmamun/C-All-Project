using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method
{
  
    class Program
    {
        public delegate int Calculate(int num1, int num2);      //Delegate Method
        static void Main(string[] args)
        {
            #region  //Anonymous Method
            // This is Anonymous Method Declare AND Assign
            //Calculate C = delegate (int num1, int num2)
            // {
            //     return num1 + num2;

            // };

            //InvokeDelegates(C, 20, 30); //  Method Call
            //Console.ReadKey();

            #endregion

            #region   ////Anonymous Method use lamda expression
            //Lamda Expression use in Anonymous Method
            //Calculate C = (int num1, int num2) => num1 + num2;

            //Lamda Expression use in Anonymous Method when you use in bracket must write return
            Calculate C = (num1, num2) =>   //lamda does't matter data type in Anonymous Method
             {
                 return num1 + num2;
             };

            //InvokeDelegates(C, 20, 30); //  Method Call
            //Console.ReadKey();
            #endregion

        }
        public static void InvokeDelegates(Calculate C,int num1, int num2)
        {
            int result= num1 + num2;
            Console.WriteLine(result);
        }
        
    }
}
