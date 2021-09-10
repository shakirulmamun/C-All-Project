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
            Drawing myCircle = new Circle();
            Console.WriteLine("The Area is :" +myCircle.Area());
            Drawing myRactangle = new Rectangle();
            Console.WriteLine("The Area is :" + myRactangle.Area());
            Drawing mySquare = new Square();
            Console.WriteLine("The Area is :" + mySquare.Ayoton());
            Console.ReadKey();
        }
    }
}
