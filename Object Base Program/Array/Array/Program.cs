using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            names[0] = "Ms. Shakirul Mamun";
            names[1] = "Mukta";
            names[2] = "Zahid";
            names[3] = "Rakib";
            Console.WriteLine(names[2]);
            ArrayList(names);
            Console.ReadKey();
        }
        static void ArrayList(string[] names)
        {
            foreach(string show in names)
            {
                Console.WriteLine(show);
            }
            
        }
        
        
       

    }
}



//int[] pins = { 1, 2, 3, 4, 5 }; //single array
//foreach (int pin in pins)
//    Console.WriteLine(pins);
//Console.ReadKey();

//var names = new[] {new{Name="Mamun", age=23},   //Multiple array
//                            new {Name="Rakib", age=30 } };

//foreach (var nameage in names)
//{
//    Console.WriteLine(nameage);
//}