using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing circle = new Circle();
            Console.WriteLine("Area is :" + circle.Area());
            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area is :" + rectangle.Area());
            Drawing squre = new Square();
            Console.WriteLine("Area is :" + squre.Area());
            Console.ReadKey();
        }
    }
}
