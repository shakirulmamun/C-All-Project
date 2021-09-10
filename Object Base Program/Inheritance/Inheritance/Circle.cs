using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // example of inheritance
    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()     //Constructor
        {
            Radius = 5; // encapculation
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }

        //Preventing Derived class from overriding virtual members
        // Ayoton() method can be override because Ayoton() method declared as sealed
        public sealed override double Ayoton()
        {
            return 0;
        }
    }

}
