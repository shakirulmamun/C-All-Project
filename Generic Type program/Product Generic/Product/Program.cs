using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program

    {

        static void Main(string[] args)

        {

            var pList = Product.Get();

            var cList = Category.Get();

            Console.WriteLine("Please Input your category to see products");

            string cate = Console.ReadLine();

            var result = (from p in pList

                          join c in cList

                          on p.CID equals c.CategoryID

                          where c.CName == cate

                          select new { p.PID, p.PName, c.CName }).ToList();

            if (result.Count == 0)

            {

                Console.WriteLine("no product found regarding category " + cate);

            }

            else

            {

                Console.WriteLine("search result");

                Console.WriteLine("Product ID     Product Name    Category ");

                foreach (var r in result)

                {

                    Console.WriteLine(r.PID + "             " + r.PName + "         "  +  r.CName );

                }

            }

            Console.ReadKey();

        }

    }

}
