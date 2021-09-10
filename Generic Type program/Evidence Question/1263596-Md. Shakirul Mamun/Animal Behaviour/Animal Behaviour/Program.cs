using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Behaviour
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Animal cow = new Animal { Name = "cow", Age = 2, Type = AnimalType.Cow };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericAnimal(cow));
            Console.WriteLine("======================");
            Console.ReadKey();
        }
    }
}
