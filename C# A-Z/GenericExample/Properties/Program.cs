using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement process not right way
            //Student st = new Student();
            //st._id = 101;
            //st._name = "Mamun";
            //st._roll = -4;  //Restriction less for (-)
            //Console.WriteLine(st._roll);

            //Auto Implement Property implement
            Student st = new Student();
            st.Id = 100;
            st.Roll = 1;
            Console.WriteLine("Student Id : " + st.Id);
            Console.WriteLine("Student Roll : " + st.Roll);


            Console.ReadKey();
        }
    }

    //Declaring process not right way
    public class Student
    {
        //public int _id;
        //public string _name;
        //public int _roll;

        //Conditional Property

        //public int Id
        //{
        //    set
        //    {
        //        if (value <0)
        //        {
        //            Console.WriteLine("Id can not be Negative");
        //        }
        //        else
        //        {
        //            this._id = value;
        //        }
        //    }
        //    get
        //    {
        //        return this._id;

        //    }
        //}

        public int Id { get; set; }
        public int Roll { get; set; }
    }


}
