using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Example
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //class calling simple way
            //Student st = new Student();
            //st.Name = "Md. Shakirul Mamun";
            //st.Age = 23;
            //st.Success = "pass";
            //Console.WriteLine(st.Success);



            //Student st = new Student() { Name = "Mamun", Age=20, Success="pass" };
            //Console.WriteLine(st.Success);


            //Generic way  call
            Student<string,string> student = new Student<string,string>() { Name = "Sawon", Age = "Ten years old", Success = "pass" };
            //Console.WriteLine(student.Age);

            //Student<int> st = new Student<int>();
            //st.Age = 1;
            //Console.WriteLine(st.Age);

            Student<int, string> student1 = new Student<int,string>() { Name = "Sawon", Age = 1, Success = "pass" };
            //Console.WriteLine(student1.Age);

            var student2 = new Student<bool,string>() { Name = "Sawon", Age = true, Success = "pass" };
            //Console.WriteLine(student2.Age);

            //Method Call 

            Print(student);
            Print(student1);
            Print(student2);
            Console.ReadKey();
        }


        public static void Print<T,u>(Student<T,u> student)
        {
            Console.WriteLine("Name : "+student.Name+ " " +"Result: "+student.Age);
        }


    }

   
    public class Student<t, u>
    {
        public string Name { get; set; }
        public t Age { get; set; }
        public u Success { get; set; }
    }

    //public class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Success { get; set; }
    //}
}
