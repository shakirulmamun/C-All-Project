using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate c = new Calculate();
            Calculate.Add(2, 3);
            Calculate.Add(3f,4f);
            Calculate.Add(3,4f);
            Console.ReadKey();
        }
    }
    public class Calculate
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public static void Add(float x, float y)
        {
            Console.WriteLine(x+y);
        }
        public static void Add(int x, float y)
        {
            Console.WriteLine(x + y);
        }
        //not possible overloading because data type is different
        //public static int Add(int x, int y,int z)
        //{
        //    Console.WriteLine(x + y);
        //}

        //not possible overloading because params keyword is not difference for overloading
        //public static void Add(int x, int y, params int[] z)
        //{
        //    Console.WriteLine(x + y);
        //}
        //public static void Add(int x, int y, int[] z)
        //{
        //    Console.WriteLine(x + y);
        //}
    }
}
