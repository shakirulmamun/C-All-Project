using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region   //Boxing 
            int anum = 123;     //value type int
            object obj = anum;      //reference type obj
            Console.WriteLine(anum);
            Console.WriteLine(obj);
            Console.ReadKey();
            #endregion

            #region  //Unboxing
            object obj1 = 456;    //reference type obj
            int anum2 = (int)obj1;   //value type int
            Console.WriteLine(anum2);
            Console.WriteLine(obj1);
            Console.ReadKey();
            #endregion

        }
    }
}
