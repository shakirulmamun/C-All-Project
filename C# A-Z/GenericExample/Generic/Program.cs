using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------Normal Object Calling and value pass---------------------

            //bool Equals = Calculator.AreEqual(4, 4);
            //if (Equals)
            //{
            //    Console.WriteLine("Equal");

            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //Console.ReadKey();

            //-----------Generic Object Calling and value pass--------------------

            // bool Equals = Calculator.AreEqual<string>("one", "one");    //string type declare use (<string>)
            //bool Equals = Calculator.AreEqual<int>(1, 1);                //int type declare use (<int>)
            //if (Equals)
            //{
            //    Console.WriteLine("Equal");

            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //Console.ReadKey();

            //-----------When one Generic class & Many method create this is process--------------

            bool Equals = Calculator<int>.AreEqual(1, 1);               
            if (Equals)
            {
                Console.WriteLine("Equal");

            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.ReadKey();
        }
    }
    //-----------------Normal class & method create ------------------------

    //class Calculator
    //{
    //    public static bool AreEqual(int value1, int value2)
    //    {
    //        return value1 == value2;
    //    }
    //}

    //-----------When one Generic class & method create this is process--------------

    //class Calculator
    //{
    //    public static bool AreEqual<T>(T value1, T value2)
    //    {
    //        return value1.Equals(value2);
    //    }
    //}

    //-----------When one Generic class & Many method create this is process--------------
    class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
