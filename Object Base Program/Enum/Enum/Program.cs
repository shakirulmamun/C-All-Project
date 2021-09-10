using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Libary item = Libary.Books;
            Console.WriteLine(item);
            Console.ReadKey();
        }
        public enum Libary
        {
            Books, Pens, Others
        }
    }
}
