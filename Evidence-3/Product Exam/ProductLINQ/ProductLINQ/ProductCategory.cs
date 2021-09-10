using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLINQ
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public ProductCategory(int productCategoryID, string name) : this()
        {
            ProductCategoryID = ProductCategoryID;
            Name = name;
        }
    }

}
