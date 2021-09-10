using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Product

    {

        public int PID { get; set; }

        public string PName { get; set; }

        public int CID { get; set; }

        public static List<Product> Get()

        {

            var pList = new List<Product>();

            var p0 = new Product();

            p0.PID = 1;

            p0.PName = " Radio ";

            p0.CID = 1;

            pList.Add(p0);

            var p1 = new Product();

            p1.PID = 2;

            p1.PName = " Washing Machine ";

            p1.CID = 1;

            pList.Add(p1);


            var p2 = new Product();

            p2.PID = 3;

            p2.PName = " Water Hitter ";

            p2.CID = 1;

            pList.Add(p2);


            var p3 = new Product();

            p3.PID = 4;

            p3.PName = "Mobile Phone";

            p3.CID = 2;

            pList.Add(p3);



            var p4 = new Product();

            p4.PID = 5;

            p4.PName = " Data Bank ";

            p4.CID = 2;

            pList.Add(p4);

            return pList;

        }

    }

}


