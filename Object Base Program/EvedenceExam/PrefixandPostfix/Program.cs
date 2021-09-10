using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixandPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Prefix 
            Console.WriteLine("prefix:");
            int i = 10;
            Console.WriteLine(i);
            Console.WriteLine(++i);
            Console.WriteLine(i);
            #endregion

            #region//Postfix 
            Console.WriteLine("Postfix:");
            int j = 7;
            Console.WriteLine(j);
            Console.WriteLine(j++);
            Console.WriteLine(j);
            #endregion


            Console.ReadKey();

        }
    }
}
