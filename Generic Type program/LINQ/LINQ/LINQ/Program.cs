using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Product> ProductList = new List<Product>();
            ProductList.Add(new Product { ProductID = 01, ProductName = "Processor",ProductPrice=7680 });
            ProductList.Add(new Product { ProductID = 02, ProductName = "Hard Disk", ProductPrice = 1280 });
            ProductList.Add(new Product { ProductID = 03, ProductName = "RAM", ProductPrice = 2450 });
            ProductList.Add(new Product { ProductID = 04, ProductName = "Processor", ProductPrice = 3400 });
            ProductList.Add(new Product { ProductID = 05, ProductName = "Monitor", ProductPrice = 3000 });

            //use LINQ Query for show all product in Product list
            //var result = from p in ProductList select p;


            //use LINQ Method for show all product in Product list
            //var result = ProductList.Select(p => p);


            //use LINQ Method for filtering product based on price in Product list
            // var result = ProductList.Where(p => p.ProductPrice > 2000 && p.ProductPrice<4000);

            //use LINQ Method for filtering product based on name in Product list
            // var result = ProductList.Where(p => p.ProductName.Contains("Disk"));

            //use LINQ Method for orderby in Product list
            var result = ProductList.OrderBy(p => p.ProductName); 

            foreach (var item in result)
            {
                Console.WriteLine("Product ID: {0} | Product Name : {1}, |Product Price:{2} ", item.ProductID, item.ProductName, item.ProductPrice);
            }
            Console.ReadKey();
        }
    }
}
