using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project_Mam_
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }

        //public virtual ProductCategory ProductCategory { get; set; }
        //public virtual ProductModel ProductModel { get; set; }

        //public Product()
        //{

        //}
        //public Product(int productID, string name, int productCategoryID, int productModelID) : this()
        //{
        //    ProductID = productID;
        //    Name = name;
        //    ProductCategoryID = productCategoryID;
        //    ProductModelID = productModelID;
        //}
    }

}
