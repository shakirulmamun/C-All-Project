using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main()
        {
            int[] Subject = { 1,2,3,4 };
            foreach (int I in Subject)
            {
                Console.WriteLine(I);
            }
        }
    }
}
