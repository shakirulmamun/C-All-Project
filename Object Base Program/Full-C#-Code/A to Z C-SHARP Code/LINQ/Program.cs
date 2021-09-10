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
            #region // LINQ Query Array Example
            //Console.WriteLine("Array List..........");
            //int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };   //Array list

            ////LINQ Query Syntax to Print Numbers Greater than 3
            //IEnumerable<int> result = from numbers in Num
            //                          where numbers > 3
            //                          select numbers;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            #endregion

            #region  // LINQ Query Product List Example in collection
            //Console.WriteLine("\nProduct List.........");
            //IList<string> porductList = new List<string>()
            //{
            //    "Hard Disk",
            //    "Monitor",
            //    "Keyboard",
            //    "Mouse",
            //    "Bluetooth",
            //    "SSD Disk",
            //    "RAM",
            //    "Mother Board",
            //    "Cable"
            //};

            //var result1 = from s in porductList
            //             select s;
            //foreach (string str in result1)
            //{
            //    //same output
            //    //Console.WriteLine(str);
            //    Console.WriteLine(str.ToString());
            //}
            //Console.ReadKey();
            #endregion

            #region  // LINQ Query Product List Example in collection specefic list
            //Console.WriteLine("\nSpecific Product List ........");
            //IList<string> porductList1 = new List<string>()
            //{
            //    "Hard Disk",
            //    "Monitor",
            //    "Keyboard",
            //    "Mouse",
            //    "Bluetooth",
            //    "SSD Disk",
            //    "RAM",
            //    "Mother Board",
            //    "Cable"
            //};

            //var result2 = from s in porductList
            //              where s.Contains("Disk")
            //              select s;
            //foreach (string str in result2)
            //{
            //    //same output
            //    //Console.WriteLine(str);
            //    Console.WriteLine(str.ToString());
            //}
            //Console.ReadKey();
            #endregion

            #region  // LINQ Method Syntax use Product List Example in collection
            //Console.WriteLine("\nProduct List(Method use) .........");
            //IList<string> porductLists = new List<string>()
            //{
            //    "Hard Disk",
            //    "Monitor",
            //    "Keyboard",
            //    "Mouse",
            //    "Bluetooth",
            //    "SSD Disk",
            //    "RAM",
            //    "Mother Board",
            //    "Cable"
            //};


            //var result3 = porductList.Where(p => p.Contains("Monitor"));  //LINQ Method use

            //foreach (string str in result3)     //foreach use
            //{
            //    //same output
            //    //Console.WriteLine(str);
            //    Console.WriteLine(str.ToString());
            //}
            //Console.ReadKey();
            #endregion

            #region // Full use in LINQ Query & Method 

            //Console.WriteLine("\nProduct List(Method use .1) .........");
            //CREATE ILIST AND STORE PRODUCT NAME AND PRICE AND THEN DISPLAY VALUE USING LINQ QUERY.

            // Creating List
            //IList<ProductStore> Productlist = new List< ProductStore > ();
            //Productlist.Add(new ProductStore { productName = "Hard Disk", productPrice = 2500 });
            //Productlist.Add(new ProductStore { productName = "Mother Board", productPrice = 1234 });
            //Productlist.Add(new ProductStore { productName = "Keyboard", productPrice = 344 });
            //Productlist.Add(new ProductStore { productName = "Monitor", productPrice = 4566 });
            //Productlist.Add(new ProductStore { productName = "Mouse", productPrice = 123 });
            //Productlist.Add(new ProductStore { productName = "RAM", productPrice = 4532 });
            //Productlist.Add(new ProductStore { productName = "Cable", productPrice = 235 });
            //Productlist.Add(new ProductStore { productName = "Power Supply", productPrice = 6000 });

            //LINQ te query or syntax je kono akta use korlea result show kora jay//

            //........................Query Syntax...............................

            //LINQ Query Syntax
            //var productInfo = from p in Productlist
            //                  select p;

            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine("Product Name: {0} | Product Price: {1}", item.productName, item.productPrice);
            //}


            //........................Method Syntax...............................

            //LINQ Method Syntax. Uncomment it to see the result.
            //var result4 = Productlist.Select(p => p);

            //foreach (var item in result4)
            //{
            //    Console.WriteLine("Product Name: {0} | Product Price: {1}", item.productName, item.productPrice);
            //}

            //Console.ReadKey();


            //........................Query Syntax with Condition...............................

            //FILTER PRODUCTS BASED ON PRICE

            //LINQ Query Syntax
            //var productInfo = from p in Productlist
            //                  where (p.productPrice > 1000 && p.productPrice < 4000)
            //                  select p;


            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine("Product Name: {0} | Product Price: {1}", item.productName, item.productPrice);
            //}

            //Console.ReadKey();

            //........................Method Syntax with Condition...............................

            //FILTER PRODUCTS BASED ON PRICE USE LINQ METHOD
            //var productInfo = Productlist.Where(p => p.productPrice > 1000 && p.productPrice < 3000);


            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine("Product Name: {0} | Product Price: {1}", item.productName, item.productPrice);
            //}

            //Console.ReadKey();


            //........................PRINT RESULT USING LINQ SYNTAX..........................

            //var result5 = from p in Productlist
            //             where p.productPrice > 2000 && p.productPrice < 4000
            //             select p;

            //result5.ToList().ForEach(p => Console.WriteLine("Product Name: {0} | Product Price: {1}", p.productName, p.productPrice));
            //Console.ReadKey();

            //........................FIND PRODUCT IN LIST use Query Syntax..........................


            //var result6 = from p in Productlist
            //              where p.productName.Contains("Disk")
            //              select p;

            //result6.ToList().ForEach(p => Console.WriteLine("Product Name:{0} | Product Price:{1}", p.productName, p.productPrice));
            //Console.ReadKey();


            //........................FIND PRODUCT IN LIST use Method Syntax....................

            //var result6 = Productlist.Where(p => p.productName.Contains("Disk"));

            //result6.ToList().ForEach(p => Console.WriteLine("Product Name:{0} | Product Price:{1}", p.productName, p.productPrice));
            //Console.ReadKey();


            //........................LIST PRODUCT IN ASCENDING ORDER...................

            //var result7 = from p in Productlist
            //              orderby p.productName ascending
            //              select p;
            //result7.ToList().ForEach(p => Console.WriteLine("Product Name: {0} | Product Price:{1}",p.productName,p.productPrice));
            //Console.ReadKey();
            #endregion

            #region  //LINQ Lamda expression
            //IList<string> countries = new List<string>();

            //countries.Add("Bangladesh");
            //countries.Add("Pakistan");
            //countries.Add("Nepal");
            //countries.Add("India");

            //IEnumerable<string> result8 = countries.Select(x => x);
            //foreach (var item in result8)
            //{
            //   Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion

            #region //Lamda Expression 
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Below are the even numbers");
            //Console.WriteLine("");
            //IEnumerable<int> evennumber = numbers.Where(x => x % 2 == 0);
            //foreach (var item in evennumber)
            //{
            //    Console.WriteLine(item + " is an even number");
            //}
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Below are the Odd numbers");
            //Console.WriteLine("");
            //IEnumerable<int> oddnumber = numbers.Where(x => x % 2 != 0);
            //foreach (var item in oddnumber)
            //{
            //    Console.WriteLine(item + " is an odd number");
            //}
            //Console.ReadLine();
            //Console.ReadKey();

            #endregion

            //#region   Min number search use in lamda Expression
            //int[] myNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int minimum = myNumber.Min();
            //Console.WriteLine("The minimum Number is: {0}", minimum);
            //Console.ReadLine();
            //Console.ReadKey();

            //#endregion

            //#region   Maximum number search use in lamda Expression
            //int[] myNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = myNumber.Max();
            //Console.WriteLine("The Maximum Number is: {0}", max);
            //Console.ReadLine();
            //Console.ReadKey();

            //#endregion

            //#region   Count number search use in lamda Expression
            //int[] myNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
            //int count = myNumber.Count();
            //Console.WriteLine("The Count Number is: {0}", count);
            //Console.ReadKey();

            //#endregion

            //#region   Average number search use in lamda Expression
            //int[] myNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //double avg = myNumber.Average();
            //Console.WriteLine("The Average Number is: {0}", avg);
            //Console.ReadKey();
            //#endregion

            //#region   Sum number search use in lamda Expression
            //int[] myNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = myNumber.Sum();
            //Console.WriteLine("The Average Number is: {0}", sum);
            //Console.ReadKey();
            //#endregion

          
        }
    }

    class ProductStore
        {
            public string productName { get; set; }
            public double productPrice { get; set; }
        }
    
}
