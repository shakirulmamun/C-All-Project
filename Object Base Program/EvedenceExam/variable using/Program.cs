using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_using
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ---------Declaring, nameing & Assigning Variable--------
            int i = 10;
            int j = 8;
            int sum = i + j;
            Console.WriteLine(sum);
            #endregion

            #region----use mathmetical operator

            int SUM, SUB, MUL, DIV;
            SUM = i + j;
            Console.WriteLine(SUM);
            SUB = i - j;
            Console.WriteLine(SUB);
            MUL = i * j;
            Console.WriteLine(MUL);
            DIV = i / j;
            Console.WriteLine(DIV);
            #endregion
            Console.ReadKey();
        }
        
       
    }
}
