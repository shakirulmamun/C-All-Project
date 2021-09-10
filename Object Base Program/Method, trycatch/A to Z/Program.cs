﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_to_Z
{
    class NamedExample
    {
        static void Main(string[] args)
        {
            // The method can be called in the normal way, by using positional arguments.
            PrintOrderDetails("Gift Shop", 31, "Red Mug");

            // Named arguments can be supplied for the parameters in any order.
            PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
            PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);

          
            //PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
            //PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");    
            //PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug");                   

        }

        static void PrintOrderDetails(string sellerName, int orderNum, string productName)
        {
            if (string.IsNullOrWhiteSpace(sellerName))
            {
                throw new ArgumentException(message: "Seller name cannot be null or empty.", paramName: nameof(sellerName));
            }

            Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
            Console.ReadKey();
        }
       
    }
}
