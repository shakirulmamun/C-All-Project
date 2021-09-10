using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    public class AssemblyOneClass1
    {
        internal int Id = 101;
    }
    public class AssemblyOneClass2
    {
        public void simpleMethod()
        {
            AssemblyOneClass1 ONE = new AssemblyOneClass1();
            Console.WriteLine(ONE.Id);
        }
    }
}
