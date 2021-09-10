using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop HP  = new Laptop("HP");
            HP.Price();
            HP.Processor();
            HP.Ram();
            HP.HardDrive();


            Console.WriteLine("\n\n*********************\n");
            Laptop DELL = new Laptop("DELL");
            DELL.Price1();
            DELL.Processor1();
            DELL.Ram1();
            DELL.HardDrive1();

            Console.WriteLine("\n\n*********************\n");
            Laptop Assus = new Laptop("Assus");
            Assus.Price2();
            Assus.Processor2();
            Assus.Ram2();
            Assus.HardDrive2();

            Console.ReadKey();
        }




    }

    class Laptop : LaptopCategory
    {
        public Laptop(String LaptopName) : base(LaptopName)
        {
        }

    }

    class LaptopCategory
    {
        public LaptopCategory(String LaptopName)
        {
            Console.WriteLine("This is " + LaptopName);
        }

        public void Price()
        {
            Console.WriteLine("Price: 50000");
        }

        public void Price1()
        {
            Console.WriteLine("Price: 67000");
        }

        public void Price2()
        {
            Console.WriteLine("Price: 67000");
        }

        public void Processor()
        {
            Console.WriteLine("Processor: Intel");
        }

        public void Processor1()
        {
            Console.WriteLine("Processor: Intel");
        }
        public void Processor2()
        {
            Console.WriteLine("Processor: Intel");
        }


        public void Ram()
        {
            Console.WriteLine("Ram : 2GB");
        }
        public void Ram1()
        {
            Console.WriteLine("Ram : 3GB");
        }
        public void Ram2()
        {
            Console.WriteLine("Ram : 4GB");
        }

        public void HardDrive()
        {
            Console.WriteLine("HDD: 500GB");
        }
        public void HardDrive1()
        {
            Console.WriteLine("HDD: 500GB");
        }
        public void HardDrive2()
        {
            Console.WriteLine("HDD: 500GB");
        }

    }

}
