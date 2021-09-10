using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ---------Declaring, nameing & Assigning Variable--------
            Console.WriteLine("Declaring, nameing & Assigning Variable--------");
            int i = 10;
            int j = 8;
            int sum = i + j;
            Console.WriteLine(sum);
            #endregion

            #region----Useing mathmetical operator
            Console.WriteLine("\n\nuse mathmetical operator--------\n");

            int SUM, SUB, MUL, DIV;
            SUM = i + j;
            Console.WriteLine("Total Sum is: "+SUM);
            SUB = i - j;
            Console.WriteLine("Total Substruct is: " + SUB);
            MUL = i * j;
            Console.WriteLine("Total Multipication is: " + MUL);
            DIV = i / j;
            Console.WriteLine("Total Division is: " + DIV);
            Console.ReadKey();
            #endregion

            #region        //Prefix
            Console.WriteLine("\nPrefix..........");
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            #endregion

            #region           //Postfix 
            Console.WriteLine("\nPostfix.................");
            int b = 7;
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
            Console.ReadKey();

            #endregion

        }
    }
}
