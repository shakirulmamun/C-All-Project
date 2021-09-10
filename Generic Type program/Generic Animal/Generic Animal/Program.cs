using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name = "cow", Age = 12, type = AnimalType.Harvivore, gender=Gender.Male };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericAnimal(cow));
            Console.WriteLine(animal.GetGenders(cow));
            Console.ReadKey();
        }
    }

}
