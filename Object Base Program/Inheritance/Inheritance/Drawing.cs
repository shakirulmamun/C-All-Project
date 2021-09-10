using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Drawing
    {
        // Area() method can be override because Area() method declared as virtual
        public virtual double Area()
        {
            return 0;
        }

        public virtual double Ayoton()
        {
            return 0;
        }

        public virtual void Skip()
        {

        }
    }

}
