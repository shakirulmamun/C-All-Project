using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple array create kora switch case er value print

            Customer[] customers = new Customer[3];    //Create Customer Array

            customers[0] = new Customer()   //Value assaign
            {
                Name = "Mamun",
                Gender = Gender.Male

            };
            customers[1] = new Customer()
            {
                Name = "Salma",
                Gender = Gender.Female

            };
            customers[2] = new Customer()
            {
                Name = "Rakib",
                Gender = Gender.Unkonown

            };
            foreach (Customer info in customers)
            {
                Console.WriteLine("Name= {0} & Gender = {1}", info.Name, GetGender(info.Gender));

            }

            //int[] values = (int[])Enum.GetNames(typeof(Gender));
            //foreach (int item in values)
            //{
            //    Console.WriteLine("Gender value: {0}", item);
            //}

            Gender g = (Gender)Subject.Bangla;      //Cast kora hoicea 
            Console.WriteLine(g);
            Console.ReadKey();
        }

        public static string GetGender(Gender gender)         //Method
        {
            switch (gender)
            {
                case Gender.Unkonown:
                    return "Unknown";

                case Gender.Male:
                    return " Male";

                case Gender.Female:
                    return " Female";

                default:
                    return "Invalid data for Gender";

            }
        }
    }
    class Customer      //Class with property
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        
    }

    public enum Gender
    {
        Unkonown=0, 
        Male=1, 
        Female=2
    }

    public enum Subject
    {
        Bangla=0,
        English=1,
        Math=3
    }
    
}
