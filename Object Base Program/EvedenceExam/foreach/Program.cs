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
            string[] books = { "Math", "Bangla", "English", "PHP" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            Console.ReadKey();
        }
    }
}
