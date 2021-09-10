using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter
{
    public class Optional
    {
        public static int sum(params int[] paramList)
        {
            int sumTotal=0;
            foreach(int i in paramList)
            {
                sumTotal += i;
            }
            return sumTotal;
        }
        public static int sum(int parm1=0, int parm2 = 0, int parm3 = 0)
        {
            int sumTotal;
            sumTotal = parm1 + parm2 + parm3;
            return sumTotal;
        }
    }
}
