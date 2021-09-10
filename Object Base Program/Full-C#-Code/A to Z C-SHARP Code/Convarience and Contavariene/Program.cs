using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convarience_and_Contavariene
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

        static Big Method4(Small sml)
        {
            Console.WriteLine("Method3");

            return new Big();
        }

        static void Main(string[] args)
        {
            covarDel del = Method4;

            Small sm = del(new Big());
            Console.ReadKey();
        }
    }
}
