using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Isummation sm = new Calculate();
            var result = sm.sum(20, 10);
            Console.WriteLine(result);
            Isubtruction sb = new Calculate();
            var result1 = sb.sub(100, 20);
            Console.WriteLine(result1);
            Imultipication ml = new Calculate();
            var result2 = ml.mul(100, 20);
            Console.WriteLine(result2);
            Idivision dv = new Calculate();
            var result3 = dv.div(100, 20);
            Console.WriteLine(result3);
            Console.ReadKey();
        }
    }
}
