using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Program
    {
        #region //Constructor Chain
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string GetfullName()
        {
            string fullName = FirstName+ " " + MiddleName+ " " + LastName;
            return fullName;
        }
        public Program(string firstName, string middleName, string lastName):this(firstName,lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Program(string firstName, string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Program()
        {

        }
        #endregion


        //#region Default Constructor
        //class Person
        //{
        //    string user;
        //    int age;
        //    string Address;

        //    //Default Constructor
        //    public Person()
        //    {
        //        user = "Steven";
        //        age = 28;
        //        Console.WriteLine("Previous User {0} and he was {1} year old", user, age);
        //    }

        //    //Parameterized Constructor /Constructor Overloading
        //    public Person(string name, int age1)
        //    {
        //        user = name;
        //        age = age1;
        //        Console.WriteLine("Current User {0} and he is {1} year old", user, age);
        //    }

        //    public Person(string name, int age1, string address) //Again Constructor Overloading
        //    {
        //        user = name;
        //        age = age1;
        //        Address = address;
        //        Console.WriteLine("Current User {0} and he is {1} year old His Address is {2} ", user, age, Address);
        //    }
        //}
        //#endregion


        static void Main(string[] args)
            {

            Program program1 = new Program(firstName:"Md.", middleName:"Shakirul", lastName:"Mamun");
            string fullNme = program1.GetfullName();
            Console.WriteLine(fullNme);


            //Method cara only object create korea deka jay
            //program1.FirstName = "Md.";
            //program1.MiddleName = "Shakirul";
            //program1.LastName = "Mamun";
            //Console.WriteLine(program1.FirstName+" "+program1.MiddleName+" "+program1.LastName);
            Console.ReadKey();


            #region //Default Constructor 
            //Default Constructor
            //Person p = new Person(); //Default Constructor Called
            //Person p1 = new Person("Clark", 35); //Overloaded Constructor
            //Person p3 = new Person("Officer", 40, "Kurigram"); //Again Overloadeing Constructor
            //Console.ReadLine();
            #endregion


        }



    }
    
}
