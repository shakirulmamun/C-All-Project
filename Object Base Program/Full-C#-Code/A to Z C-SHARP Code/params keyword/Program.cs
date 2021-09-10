using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            paramsMethod(1, 2, 3, 4, 5, 6, 7);
        }
        public static void paramsMethod(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)

            {

                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));

            }
            Console.WriteLine();
            Console.WriteLine("\nPress any key to Exit");
            Console.ReadKey();
        }

    }
}
