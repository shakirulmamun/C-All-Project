using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitasking1
{
    class Program

    {
        static void Main(string[] args)

        {
            for (int i = 1; i <= 20; i++)

            {

                if (i % 3 == 0)

                {
                    FactorialUsingTask(i);
                }
            }

            Console.WriteLine("Hit <Enter> to exit");

            Console.ReadLine();
        }

        private static void FactorialUsingTask(int x)

        {
            Task.Run<long>(() =>

            {
                long r = FactorialWithDelay(x);

                return r;
            })

            .ContinueWith((t) =>

            {
                Console.WriteLine($"{x}!={t.Result}");
            });
        }

        private static long FactorialWithDelay(int n)

        {
            long f = 1;

            for (int i = n; i >= 1; i--)

            {
                Thread.Sleep(100);
                f *= i;
            }
            return f;
        }

    }

}
