using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trangle
{
    class Polygon
    {
        public int NumSides { get; set; }
        public double LengthSide { get; set; }
        public Polygon()
        {
            this.NumSides = 4;
            this.LengthSide = 5.5;
        }

    }
}
