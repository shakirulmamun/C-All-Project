using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Square:Drawing
    {
        public double Length { get; set; }
        public Square()
        {
             Length = 6;
        }
        public override double Ayoton()
        {
            return Math.Pow (Length,2);
        }
        public override void skip()
        {
            base.skip();
        }

    }
}
