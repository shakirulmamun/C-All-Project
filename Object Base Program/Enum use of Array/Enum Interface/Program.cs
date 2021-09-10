using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months =  {"January","February", "March","April", "May", "June" };
            foreach(string i in Months)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
       
    }
        
}
