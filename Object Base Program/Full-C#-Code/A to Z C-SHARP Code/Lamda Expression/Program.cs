using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expression
{
    class Program
    {
        //Delegate function start
        public delegate bool FindEvenNumber(int num);
        public static bool EvenNumber(int num)
        {
            return (num % 2 == 0);
        }

        //Delegate function end
        static void Main(string[] args)
        {

            //-------------------------------------------------------------------------
            //Difference between Delegate function & Lamda Expression
            //-------------------------------------------------------------------------
            //Find Even Number (0-100) use normal Function

            //FindEvenNumber number = EvenNumber;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (number(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadKey();


            //}





            ////use lamda expression output multiply
           
            //Func<int, int, long> Multiply = (num1, num2) => num1 * num2;
            //Console.WriteLine(Multiply(2,3).ToString());
            //Console.ReadKey();


            //-------------------------------------------------------------------------
            //Difference between Normal function & Lamda Expression
            //-------------------------------------------------------------------------
            //Find Even Number (0-100) use normal Function

            //Program p = new Program();
            //for (int i = 0; i < 100; i++)
            //{
            //    if (p.EvenNumber(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadKey();
            //}




            //Find Even Number (0-100) use lamda expression
            //Func<int, bool> EvenNumber = (i => i %2==0);
            //for (int i = 0; i <=100; i++)
            //{
            //    if (EvenNumber(i))
            //    {
            //        Console.WriteLine(i.ToString());
            //    }
            //}
            //Console.ReadKey();
        }

        //-------------------------------------------------------------------------
        //Difference between Normal function & Lamda Expression
        //-------------------------------------------------------------------------
        //Find Even Number (0-100) use normal Function
        //public bool EvenNumber(int num)
        //{
        //    return (num % 2 == 0);
        //}



        

       
    }
}
