using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        public static System.Collections.IEnumerable save()
        {
            yield return 9;
            yield return 5;
            yield return 9;
            yield return 11;
        }

        static void Main(string[] args)
        {
            foreach (int number in save())
            {
                Console.WriteLine(number.ToString());
            }
            Console.ReadKey();
        }
    }


}
