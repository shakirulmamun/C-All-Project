using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car:Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating the Car");
        }
        public void Brake()
        {
            Console.WriteLine("Breaking the Car");
        }
    }
}
