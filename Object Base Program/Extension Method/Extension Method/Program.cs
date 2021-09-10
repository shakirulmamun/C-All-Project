using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = { "Mamun", "Sawon", "Mukta" };
            var result = st.OrderBy(a => a);
            foreach(string i in result)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
