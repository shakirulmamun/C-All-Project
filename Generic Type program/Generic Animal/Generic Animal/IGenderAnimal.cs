using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal
{
    public interface IGenderAnimal<T>
    {
        string GetGenders(T obj1);
    }
}
