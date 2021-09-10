using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandConstructor
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1(5, 4);
            Console.WriteLine ("Grade: {0}, Point: {1}", obj.grade, obj.point);     //Instance of class
            Console.ReadKey();
        }
    }
}
