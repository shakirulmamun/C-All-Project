using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Behaviour
{
    public class GenericAnimal<T> : IGenericAnimal<T>
    {
        public string GetGenericAnimal(T obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.Type)
                {
                    case AnimalType.Cow:
                        behavior = "The Animal Eats Grass";
                        break;
                    case AnimalType.Cat:
                        behavior = "The Animal Eats Meat";
                        break;
                    case AnimalType.Horse:
                        behavior = "The Animal Eats EveryThing";
                        break;
                    default:
                        behavior = "unknown behavior";
                        break;
                }
            }
            else { behavior = "Not an animal"; }
            return behavior;
        }
    }
}
