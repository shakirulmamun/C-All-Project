using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 100; i = i + 10)

            {

                if (i >= 80 && i < 100)

                {
                    Console.WriteLine("Your result is Pass");
                }
                else
                {
                    Console.WriteLine("Your result is Fail");
                }
                Console.ReadKey();
            }


        }


    }
}

    
        

    

