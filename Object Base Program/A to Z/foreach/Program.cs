using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] Clothes = { "Shirt", "Pant", "T-Shirt", "Towel"};
                foreach (string Cloth in Clothes)
                {
                    Console.WriteLine(Cloth);
                }
            }
            catch(Exception)
            {

            }
            
            Console.ReadKey();

        }
    }
}
