using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------Normal Array declare and value assign----------------
            //int[] numbers =new int[3];
            //numbers[0] = 190;
            //numbers[2] = 200;
            //numbers[1] = 100;
            //foreach(int number in numbers)
            //{
            //    //Console.WriteLine(number);
            //    Console.WriteLine("Number= {0}", number);

            //}
            //Console.ReadKey();

            //---------Create Array List----------------

            //ArrayList number = new ArrayList(5);

            //number.Add(100);
            //number.Add(44);
            //number.Add(4444);
            //number.Add(2323);
            //number.Add(223);
            //number.Add(333);
            //number.Add(343);
            //number.Add(300);
            //number.Remove(12);
            //foreach (int num in number)
            //{
            //    Console.WriteLine("Array Value is = " +num);
            //}
            //Console.ReadKey();


            //---------Create Generic Array List----------------

            List<int> numbers = new List<int>(1);

            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            foreach (int item in numbers)
            {
                Console.WriteLine("Array is ={0} " , item);
            }
            
            Console.ReadKey();
        }
        
    }
}
