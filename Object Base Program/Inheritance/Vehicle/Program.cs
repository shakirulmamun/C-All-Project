using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Journey by Airplane");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.Takeoff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StoptEngine("Whir");
            Console.WriteLine("Journey by Car");
            Car myCar = new Car();
            myCar.StartEngine("Brm Brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StoptEngine("Phut Phut");
            Console.WriteLine("........................");
            Console.WriteLine("Thanks for your Journey");
            Console.ReadKey();
        }
       
    }
   
}
