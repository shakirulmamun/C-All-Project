﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=100)
            {
                Console.Write("This is Even Number  :  ");
                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadKey();
        }
    }
}
