using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  //This is Instance
            //This four property is set means seting
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 2021;
            myCar.Color = "Blue";


           

            Console.WriteLine("{0}, {1},{2},{3}",
                //This four property is get means geting
                myCar.Make, 
                myCar.Model, 
                myCar.Year,
                myCar.Color);

            Console.WriteLine(myCar.DetermineMarketValue());

            Console.ReadLine();

        //    decimal value = determineMarketValue(myCar);
        //    Console.WriteLine("{0:C}", value);
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue=100.0m;
            return carValue;
        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }


    }
}
