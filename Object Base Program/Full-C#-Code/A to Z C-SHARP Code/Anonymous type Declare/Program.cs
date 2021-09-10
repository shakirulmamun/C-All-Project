using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_type_Declare
{
    class Program
    {
        static void Main(string[] args)
        {

            Anounymous_class anounymous = new Anounymous_class();  //class call or instance

            #region // Anonymous type call
            //Anounymous type k declare and  Must be initialize
            //var Student = new
            //{

            //    ID = 1,
            //    Name = "Md.Shakirul Mamun",
            //    Address = "Kurigram"
            //};


            //type show korar way
            //Console.WriteLine(anounymous.GetType());
            //Console.WriteLine(Student.GetType());

            //total ta dekar jonno
            //Console.WriteLine(anounymous);
            //Console.WriteLine(Student);


            //Anounymous type k call korea sob property show korar jonno
            //Console.WriteLine(Student.ID);
            //Console.WriteLine(Student.Name);
            //Console.WriteLine(Student.Address);
            Console.ReadKey();
            #endregion


            #region    //Anonymous way te array call
            var StudentList = new[]
            {
                new{ID=1, Name="Mamun", Address="Kurigram"},
                new{ID=2, Name="Mukta", Address="Kurigram"},
                new{ID=3, Name="Sawon", Address="Kurigram"},
            };
            //var searchList = StudentList.Where(c => c.Name.StartsWith("M")).ToList();
            foreach (var Student2 in StudentList)
            {
                //Console.WriteLine("Length:"+StudentList.Length);
                //Console.WriteLine("============");
                Console.WriteLine("\nStudent ID:" + Student2.ID);
                Console.WriteLine("Student Name:" + Student2.Name);
                Console.WriteLine("Address:" + Student2.Address);

            }
            #endregion


        }
    }
}
