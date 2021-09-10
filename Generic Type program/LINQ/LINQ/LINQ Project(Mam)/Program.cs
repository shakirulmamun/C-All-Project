using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project_Mam_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product[] Products = new Product[]
            //{
            //    new Product { ProductID = 1, Name = "Nokia", ProductCategoryID = 2, ProductModelID = 2 },
            //    new Product { ProductID = 2, Name = "HP", ProductCategoryID = 1, ProductModelID = 1 },
            //    new Product { ProductID = 3, Name = "Iphone",ProductCategoryID = 2, ProductModelID = 3 }
            //};

            //ProductCategory[] ProductCategories = new ProductCategory[]
            //{
            //    new ProductCategory { ProductCategoryID = 1, Name = "Computer" },
            //    new ProductCategory { ProductCategoryID = 2, Name = "Mobile" },
            // };

            //ProductModel[] ProductModels = new ProductModel[]
            //{
            //    new ProductModel { ProductModelID = 1, Name = "Core i7" },
            //    new ProductModel { ProductModelID = 2, Name = "6300 4G" },
            //    new ProductModel { ProductModelID = 3, Name = "12 pro max"}
            //};
            //var result = Products
            //    .Select(pd => new { pd.Name, pd.ProductCategoryID, pd.ProductModelID })
            //    .Join(ProductCategories, pr => pr.ProductCategoryID, pc => pc.ProductCategoryID, (pr, pc) => new { pr.Name, Category = pc.Name, pr.ProductModelID })
            //    .Join(ProductModels, prc => prc.ProductModelID, pm => pm.ProductModelID, (prc, pm) => new { prc.Name, prc.Category, Model = pm.Name }).OrderBy(a => a.Name).ThenBy(a => a.Name);

            ////For Select & Where
            ////var result = Products
            ////.Where(pd => String.Equals(pd.Name, "Nokia"))
            ////.Select(pd => new { pd.Name, pd.ProductCategoryID, pd.ProductModelID });


            //foreach (var row in result)
            //{
            //    string aProduct = row.ToString();
            //    Console.WriteLine(aProduct.Replace("{ ", "").Replace(" }", ""));
            //}


            var productcategorys = new ProductCategory[]
            {
                new ProductCategory{ProductCategoryID=1, Name="Shirt"},
                new ProductCategory{ProductCategoryID=2, Name="Pant"}
            };

            var productmodel = new ProductModel[]
            {
                new ProductModel{ProductModelID=1,Name="Male"},
                new ProductModel{ProductModelID=2,Name="Female"}
            };

            var prodtcts = new Product[]
            {
                new Product{ProductID=1, Name="Polo"},
                new Product{ProductID=2, Name="Casual"},
                new Product{ProductID=3, Name="Formal"}
            };

            var pt = from p in prodtcts
                     join c in productcategorys
                     on p.ProductCategoryID equals c.ProductCategoryID
                     join m in productmodel
                     on p.ProductModelID equals m.ProductModelID
                     select new { p.Name, Model = m.Name, Categories = c.Name };

            foreach (var row in pt)
            {
                //Console.WriteLine(item.Name);
                Console.WriteLine($"{row.Name}\t,{row.Model}, {row.Categories}");
            }


            Console.ReadKey();
        }
    }

}
