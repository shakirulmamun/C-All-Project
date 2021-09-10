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
            Product[] Products = new Product[]
            {
                new Product { ProductID = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, ProductCategoryID = 18, ProductModelID = 9 },
                new Product { ProductID = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47, ProductCategoryID = 18, ProductModelID = 9 },
                new Product { ProductID = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62, ProductCategoryID = 18, ProductModelID = 9 }
                };

            ProductCategory[] ProductCategories = new ProductCategory[]
            {
                new ProductCategory { ProductCategoryID = 1, Name = "Bikes" },
                new ProductCategory { ProductCategoryID = 2, Name = "Components" },
                new ProductCategory { ProductCategoryID = 3, Name = "Clothing" },
                new ProductCategory { ProductCategoryID = 4, Name = "Accessories" },
                new ProductCategory { ProductCategoryID = 5, Name = "Mountain Bikes" },
                new ProductCategory { ProductCategoryID = 6, Name = "Road Bikes" },
                new ProductCategory { ProductCategoryID = 7, Name = "Touring Bikes" },
                new ProductCategory { ProductCategoryID = 8, Name = "Handlebars" },
                new ProductCategory { ProductCategoryID = 9, Name = "Bottom Brackets" },
                new ProductCategory { ProductCategoryID = 10, Name = "Brakes" },
                new ProductCategory { ProductCategoryID = 11, Name = "Chains" },
                new ProductCategory { ProductCategoryID = 12, Name = "Cranksets" },
                new ProductCategory { ProductCategoryID = 13, Name = "Derailleurs" },
                new ProductCategory { ProductCategoryID = 14, Name = "Forks" },
                new ProductCategory { ProductCategoryID = 15, Name = "Headsets" },
                new ProductCategory { ProductCategoryID = 16, Name = "Mountain Frames" },
                new ProductCategory { ProductCategoryID = 17, Name = "Pedals" },
                new ProductCategory { ProductCategoryID = 18, Name = "Road Frames" },
                new ProductCategory { ProductCategoryID = 19, Name = "Saddles" }
           };

            ProductModel[] ProductModels = new ProductModel[]
            {
                new ProductModel { ProductModelID = 1, Name = "Classic Vest" },
                new ProductModel { ProductModelID = 2, Name = "Cycling Cap" },
                new ProductModel { ProductModelID = 3, Name = "Full-Finger Gloves" },
                new ProductModel { ProductModelID = 4, Name = "Half-Finger Gloves" },
                new ProductModel { ProductModelID = 5, Name = "HL Mountain Frame" },
                new ProductModel { ProductModelID = 6, Name = "HL Road Frame" },
                new ProductModel { ProductModelID = 7, Name = "HL Touring Frame" },
                new ProductModel { ProductModelID = 8, Name = "LL Mountain Frame" },
                new ProductModel { ProductModelID = 9, Name = "LL Road Frame" },
                new ProductModel { ProductModelID = 10, Name = "LL Touring Frame" }
                };

            var result = Products
                .Select(pd => new { pd.Name, pd.ProductNumber, pd.StandardCost, pd.ListPrice, pd.Weight, pd.ProductCategoryID, pd.ProductModelID })
                .Join(ProductCategories, pr => pr.ProductCategoryID, pc => pc.ProductCategoryID, (pr, pc) => new { pr.Name, Category = pc.Name, pr.ProductNumber, pr.StandardCost, pr.ListPrice, pr.Weight, pr.ProductModelID })
                .Join(ProductModels, prc => prc.ProductModelID, pm => pm.ProductModelID, (prc, pm) => new { prc.Name, prc.Category, Model = pm.Name, prc.ProductNumber, prc.StandardCost, prc.ListPrice, prc.Weight }).OrderBy(a => a.Name).ThenBy(a => a.Category).ThenBy(a => a.Category);

            foreach (var row in result)
            {
                string aProduct = row.ToString();
                Console.WriteLine(aProduct.Replace("{ ", "").Replace(" }", ""));
            }
            Console.ReadKey();
        }
    }

}

