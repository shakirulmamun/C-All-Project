using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            var Categories = new Category[]
            {
                new Category { CategoryID = 1, Name = "Shirt"},
                new Category { CategoryID = 2, Name = "Pant"}
            };
            var Models = new Model[]
            {
                new Model { ModelID = 1, Name = "Man's Shirt"},
                new Model { ModelID = 2, Name = "Man's Pant"},
                new Model { ModelID = 3, Name = "Woman's Shirt"},
                new Model { ModelID = 4, Name = "Woman's Pant"}
            };
            var Products = new Product[]
            {
                new Product { ProductID = 1, Name = "Polo Shirt", ProductNumber = 1213, Color = "Blue", FixedPrice = 700, CategoryID = 1, ModelID = 1, ProductOwnerID=001},
                new Product { ProductID = 2, Name = "Casual Pant", ProductNumber = 1214, Color = "Gray", FixedPrice = 800, CategoryID = 2, ModelID = 2,ProductOwnerID=002},
                new Product { ProductID = 3, Name = "Formal Shirt", ProductNumber = 1222, Color = "White", FixedPrice = 500, CategoryID = 1, ModelID = 1,ProductOwnerID=003},
                new Product { ProductID = 4, Name = "Formal Pant", ProductNumber = 1223, Color = "Black", FixedPrice = 600, CategoryID = 2, ModelID = 2,ProductOwnerID=009},
                new Product { ProductID = 5, Name = "Polo Shirt", ProductNumber = 1231, Color = "Orange", FixedPrice = 700, CategoryID = 1, ModelID = 3,ProductOwnerID=007},
                new Product { ProductID = 6, Name = "Casual Pant", ProductNumber = 1232, Color = "Red", FixedPrice = 800, CategoryID = 2, ModelID = 4,ProductOwnerID=004},
                new Product { ProductID = 7, Name = "Formal Shirt", ProductNumber = 1241, Color = "White", FixedPrice = 500, CategoryID = 1, ModelID = 3,ProductOwnerID=010},
                new Product { ProductID = 8, Name = "Formal Pant", ProductNumber = 1242, Color = "Black", FixedPrice = 600, CategoryID = 2, ModelID = 4,ProductOwnerID=0012}
            };
            // var Garments = from p in Products
            //                join c in Categories
            //                on p.CategoryID equals c.CategoryID
            //                join m in Models
            //                on p.ModelID equals m.ModelID
            //                select new { Product = p.ProductID, Category = c.Name, Model = m.Name, p.Name, p.Color, p.FixedPrice,p.ProductOwnerID };

            // foreach (var x in Garments)
            // {

            //Console.WriteLine($"{x.Name}\t {x.Model}\t {x.Color}\t {x.FixedPrice}\t {x.ProductOwnerID}");
            // }

            var item = from p in Products
                       group p by p.Color;
            //where p.Name =="Polo Shirt"
            // where p.FixedPrice>400
            //orderby p.Name descending
            // select p;

            foreach (var group in item)
            {
                Console.WriteLine(string.Format("Category: {0}", group.Key));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.Name, name.Color));
                }
            }

            //foreach (var items in item)
            //{
            //    Console.WriteLine($"{items.Name}");
            //}

            Console.ReadKey();
        }

    }
}

