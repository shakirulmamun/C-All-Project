using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Product
{
   public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int ProductNumber { get; set; }
        public string Color { get; set; }
        public double FixedPrice { get; set; }
        public int CategoryID { get; set; }
        public int ModelID { get; set; }
        public int ProductOwnerID { get; set; }
    }
}
