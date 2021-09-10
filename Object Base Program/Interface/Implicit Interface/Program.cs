using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse hr = new Horse();
            IJourney journeyHorse = hr;
            int legsJourney = journeyHorse.NumberOflages();
            ILandBound landBoundHorse = hr;
            int legsHorse = landBoundHorse.NumberOflages();
            Console.WriteLine(legsJourney);
            Console.WriteLine(legsHorse);
            Console.ReadKey();
        }
    }
}
