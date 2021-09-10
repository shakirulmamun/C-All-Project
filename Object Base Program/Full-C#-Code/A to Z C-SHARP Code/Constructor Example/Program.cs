using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    class Program
    {
        #region // property use kore constructor declare and value assigning
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Program(string firstName, string middleName, string lastName) //constructor has no return type only assigning value
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string GetfullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }
        #endregion
        //property

        static void Main(string[] args)
        {

            //object create and consturctor er vitor value/argument pass
            Program p = new Program(firstName: "Md", middleName: "Shakirul", lastName: "Mamun");
            //Jodi kono value change kortea cai tahole ai process ao kora jay
            p.FirstName = "Sawon";
            p.MiddleName = "Ali";
            p.LastName = "Khan";
            string fullName = p.GetfullName();   //Method Call
            Console.WriteLine(fullName);
            Console.ReadKey();

            ////Simple Constructor Example
            //Teacher Teacher1 = new Teacher();
            //Console.WriteLine(Teacher1.Name + " " + Teacher1.Gender + " " + Teacher1.Age);
            //Console.ReadKey();
            
                
        }

       
    }
    #region  //Simple Constructor Example
    class Teacher
    {
        public string Name, Gender;
        public int Age;

        public Teacher()
        {
            Name = "Md. Shakirul Mamun";
            Gender = "Male";
            Age = 26;
        }
    }
    #endregion

}
