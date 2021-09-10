using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public void StartEngine(String noisetoMakeWhenStarting)
        {
            Console.WriteLine("Starting Engine : ");
        }
        public void StoptEngine(String noisetoMakeWhenStoping)
        {
            Console.WriteLine("Stoping Engine : ");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default Implementaion of the Drive Method ");
        }
    }
}
