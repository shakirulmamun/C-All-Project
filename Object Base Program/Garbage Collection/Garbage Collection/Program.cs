using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    public class Garbage    //garbage class
    {
        public Garbage()        //constructor
        {
            Console.WriteLine("Resever Memory");
        }
        ~Garbage()  //distractor
        {
            Console.WriteLine("Free Memory");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garbage g = new Garbage();      //object
            g = null;
            GC.Collect();       //System er GC and Collect is method
            Console.ReadKey();
        }
    }
}
