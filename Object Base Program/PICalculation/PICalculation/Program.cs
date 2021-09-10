using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(20);        //Instance of class
            double areaofCircle = c.Area();
            Console.WriteLine(areaofCircle);
            Console.ReadKey();
        }
    }
}
