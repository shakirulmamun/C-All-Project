using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Calculate : Isummation, Isubtruction, Imultipication, Idivision //implement
    {
        int Isummation.sum(int num1, int num2)
        {
        return num1+num2;
        }
        int Isubtruction.sub(int num1, int num2)
        {
            return num1 - num2;
        }
        int Imultipication.mul(int num1, int num2)
        {
            return num1 * num2;
        }
        int Idivision.div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
    
}
