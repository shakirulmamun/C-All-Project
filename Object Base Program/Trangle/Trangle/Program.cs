using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
    static void doWork()
    {
        Polygon square = new Polygon();
        Polygon triangle = new Polygon { NumSides = 3 };
        Polygon pentagon = new Polygon { NumSides = 3, LengthSide=4.4 };
        Console.WriteLine($"{ square.NumSides},{ square.LengthSide}");
        Console.WriteLine($"")
      

    }
}
