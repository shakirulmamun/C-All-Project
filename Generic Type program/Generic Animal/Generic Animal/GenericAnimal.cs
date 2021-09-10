using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal
{
    public class GenericAnimal<T> : IGenericAnimal<T>
    {
        public string GetGenericAnimal(T obj)
        {
            string behavior = string.Empty;

            if (obj is Animal)
            {
                Animal a = obj as Animal;

                switch (a.type)
                {
                    case AnimalType.Harvivore:
                        behavior = "The Animal Eats Grass";
                        break;
                    case AnimalType.carnivore:
                        behavior = "The Animal Eats Meat";
                        break;
                    case AnimalType.Omnivore:
                        behavior = "The Animal Eats EveryThing";
                        break;
                    default:
                        behavior = "unknown behavior";
                        break;
                }
            }
            else 
            { 
                behavior = "Not an animal"; 
            }
            return behavior;
        }

        public string GetGenders(T obj1)
        {
            string sex = string.Empty;

            Animal a = obj1 as Animal;

            if(obj1 is Animal)
            {
                switch (a.gender)
                {
                    case Gender.Male:
                        sex = "Thia Animal Gender is Male";
                        break;
                    case Gender.Female:
                        sex = "Thia Animal Gender is Female";
                        break;

                    default:
                        sex = "Others";
                        break;
                }
            }

            else
            {
                sex = "This is Third Gender";
            }
            return sex;
        }
    }
}
