using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    class ProgEg
    {
        static string s = null;
        static void disp(string s1)
        {
            if (s1 == null)
                throw new NullReferenceException("Exception Found.");
        }
        static void Main(string[] args)
        {
            try
            {
                disp(s);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
