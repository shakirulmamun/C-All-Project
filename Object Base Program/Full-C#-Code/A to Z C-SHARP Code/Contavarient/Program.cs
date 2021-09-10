using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contavarient
{
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
    delegate Small covarDel(Big mc);

    class Program
    {
        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");

            return new Small();
        }
        static void Main(string[] args)
        {
            covarDel del = Method1;
            del += Method2;
            del += Method3;

            Small sm = del(new Big());
            Console.ReadKey();
        }
    }
}
