using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Square : Drawing
    {
        public double Length { get; set; }
        public Square()
        {
            Length = 6;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }

        //Accessing Base class virtual member
        //Using the "base" keyword, the derived class is able to access the method.
        public override void Skip()
        {
            base.Skip();
        }
    }
}
