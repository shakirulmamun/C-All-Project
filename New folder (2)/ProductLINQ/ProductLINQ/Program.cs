using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Product[]
            {
                new Product{ProductID=1, Name="T-Shirt", Price=200, Color="Red", CategoryID=1, ModelID=1 },
                new Product{ProductID=2, Name="Polo Shirt", Price=800, Color="White", CategoryID=2, ModelID=2 },
                new Product{ProductID=3, Name="Casual Pant", Price=600, Color="Blue", CategoryID=3, ModelID=3 },
                new Product{ProductID=4, Name="Formal Shirt", Price=900, Color="Yellow", CategoryID=1, ModelID=4 },
                new Product{ProductID=5, Name="Formal Pant", Price=400, Color="NavyBlue", CategoryID=2, ModelID=5 },
                new Product{ProductID=6, Name="T-Shirt", Price=500, Color="Red", CategoryID=3, ModelID=6 },
                new Product{ProductID=7, Name="Polo Shirt", Price=200, Color="Green", CategoryID=1, ModelID=1 },
                new Product{ProductID=8, Name="Casual Pant", Price=800, Color="Black", CategoryID=2, ModelID=2 },
                new Product{ProductID=9, Name="Formal Shirt", Price=700, Color="White", CategoryID=3, ModelID=3},
                new Product{ProductID=10, Name="Formal Pant", Price=700, Color="Black", CategoryID=1, ModelID=6 }
            };

            var categories = new Category[]
            {
                new Category{CategoryID=1, Name="T-Shirt"},
                new Category{CategoryID=2, Name="Shirt"},
                new Category{CategoryID=3, Name="Pant"}
            };
            var models = new Model[]
            {
                new Model{ModelID=1, Name="Man's T-Shirt"},
                new Model{ModelID=2, Name="Man's Shirt"},
                new Model{ModelID=3, Name="Man's Pant"},
                new Model{ModelID=4, Name="Women's T-Shirt"},
                new Model{ModelID=5, Name="Women's Shirt"},
                new Model{ModelID=6, Name="Women's Pant"}
            };

            //---------------------------Use Join Query -------------------------

            //var result = from p in products
            //             join c in categories
            //             on p.ProductID equals c.CategoryID
            //             join m in models
            //             on p.CategoryID equals m.ModelID
            //             select new { product = p.ProductID, Category = c.Name, Model = m.Name, p.Name, p.Color, p.Price };
            //foreach (var item in result)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine("\nProduct Name:\t" + $"{item.Name}");
            //    Console.WriteLine("Product Price:\t" + $"{item.Price}");
            //    Console.WriteLine("Product Color:\t" + $"{item.Color}");
            //    Console.WriteLine("Product Model:\t" + $"{item.Model}");
            //    Console.WriteLine("\n===================================\n");
            //}



            //---------------------------Use Where Query -------------------------

            //var result1 = from p in products
            //                  //where p.Price > 300               //1st use
            //                  //where p.Name == "T-Shirt"         //2nd use
            //             select p;
            //foreach (var items in result1)
            //{
            //    Console.WriteLine("\nProduct Name:\t" + $"{items.Name}");
            //    Console.WriteLine("Product Price:\t" + $"{items.Price}");
            //    Console.WriteLine("Product Color:\t" + $"{items.Color}");
            //    Console.WriteLine("\n===================================\n");
            //}



            //---------------------------Use Group by Query -------------------------

            //var result2 = from p in products
            //           group p by p.Color;

            //foreach (var group in result2)
            //{
            //    Console.WriteLine(string.Format("Category: {0}",group.Key));
            //    foreach (var name in group)
            //    {
            //        Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}\n", name.Name, name.Color));
            //    }
            //}

            //---------------------------Use Order by Query -------------------------

            //var result3 = from p in products
            //              orderby p.Name descending
            //              select p;
            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item.Name);

            //}

            //---------------------------Use Having/Where Query -------------------------

            //var result4 = from p in products
            //            group p by p.Name into g
            //            where g.Count()>1
            //            select new { Name = g.Key, Total = g.Count() };
            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item.Name);

            //}







            Console.ReadKey();
        }
    }
}
