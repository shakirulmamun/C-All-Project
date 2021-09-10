using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading1
{
    class Class1
    {
        public int number;
        public Class1()
        {
            number = 0;
        }
        public Class1(int n)
        {
            number = n;
        }
        public static Class1 operator +(Class1 d1, Class1 d2)
        {
            Class1 d3 = new Class1();
            d3.number = d1.number + d2.number;
            return d3;
        }
        public void display()
        {
            Console.WriteLine("{0}", number );
        }
    }
}

