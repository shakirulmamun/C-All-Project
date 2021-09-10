using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Md. Shakirul Mamun");
            names.Add("Md. Sawon");
            names.Add("MUKTA");
            names.Add("Sahanaj");
            names.Add("musa");

            //Predicate<string> nameSearch = IsCheckName;  // only method call
            //Predicate<string> nameSearch = x => x.StartsWith("m");   //lamda expression use and write anounimous method
            var data = names.FindAll(x => x.StartsWith("m"));  // A VABEAO LIKEA JAY
            //var data = names.FindAll(nameSearch);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static bool IsCheckName(string name)
        {
            if (name.StartsWith("M"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
