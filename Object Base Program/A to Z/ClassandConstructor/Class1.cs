using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandConstructor
{
    class Class1
    {
        public int grade;       //Property declare without Initialize
        public int point;
    public Class1(int grade, int point)
        {
            this.grade = 5;     //Property declare in Constructor
            this.point = 4;
        }
    }
}
