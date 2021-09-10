using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 32;
            //int b = 6;
            //int c = 0;

            //Binary.........................

            //c = a & b;     //AND
            //Console.WriteLine(Convert.ToString(c, 2));

            //c = a | b;  //OR
            //Console.WriteLine(Convert.ToString(c, 2));

            //c = a ^ b;  //XOR
            //Console.WriteLine(Convert.ToString(c, 2));

            //c = a << b; //Left Shift
            //Console.WriteLine(Convert.ToString(c, 2));

            //c = a >> b; //Right Shift
            //Console.WriteLine(Convert.ToString(c, 2));


            //octa ..........................
            //c = a & b;

            //Console.WriteLine(Convert.ToString(c, 8));

            //c = a | b;

            //Console.WriteLine(Convert.ToString(c, 8));

            //c = a ^ b;

            //Console.WriteLine(Convert.ToString(c, 8));

            //c = a << b;

            //Console.WriteLine(Convert.ToString(c, 8));

            //c = a >> b;

            //Console.WriteLine(Convert.ToString(c, 8));

            //string name = "jpit";
            //Console.WriteLine(name.IndexOf("J"));
            //Console.WriteLine(name.["2"]);

            //Swapping..........................

            int i, k;
            Console.Write("Enter 1st Integers Number: \t");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Integers Number: \t");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Before Swapping i={0} and k={1}", i, k);
            i = i ^ k;
            k = i ^ k;
            i = i ^ k;
            Console.WriteLine("\n After Swapping i={0} and k={1}", i, k);
            Console.ReadKey();

        }
    }
}
