using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle:Drawing        //inheritance
    {
        public double radious { get; set; }
        public Circle()         //Constructor
        {
           
            radious = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(radious,2);
        }
        public sealed override double Ayoton()
        {
            return 0;
        }
    }
}
