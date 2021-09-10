using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Category

    {
        public int CategoryID { get; set; }
        public string CName { get; set; }
        public static List<Category> Get()

        {

            var cList = new List<Category>();

            var c1 = new Category();

            c1.CategoryID = 1;

            c1.CName = "Electronics";


            var c2 = new Category();

            c2.CategoryID = 2;

            c2.CName = "Telecom";

            cList.Add(c1);

            cList.Add(c2);

            return cList;

        }

    }

}

