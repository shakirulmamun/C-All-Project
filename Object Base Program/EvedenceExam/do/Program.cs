﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @do
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                a++;
                Console.WriteLine(a);
                Console.ReadKey();
            } 
            while (a<5);
        }
        
    }
}
