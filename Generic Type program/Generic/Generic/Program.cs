using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name = "cow", Age = 2, Type = AnimalType.carnivore };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericAnimal(cow));

            Animal bear = new Animal { Name = "Grizzly", Age = 4, Type = AnimalType.Omnivore, Sex = Gender.Male };
            TypeSpecificAnimal<Animal> obj2 = new TypeSpecificAnimal<Animal>();
            Console.WriteLine(obj2.GetTypeSpecificBehavior(bear));
            Console.ReadKey();
        }
    }
}
