using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------Public------------------------------------

            ////Access Modifier Public , so call any where no problem

            //ClassA a = new ClassA();
            //a.Name = "Mamun";
            //Console.WriteLine(a.Name);

            //ClassB b = new ClassB();
            //b.Address = "Mirpur-1, Tollarbag, Dhaka";
            //Console.WriteLine(b.Address);
            //Console.ReadKey();

            //---------------------Private------------------------------------

            //Access Modifier Private , so don't call any where

            //    ClassA a = new ClassA();
            //    a.Name = "Mamun";
            //    Console.WriteLine(a.Name);

            //    ClassB b = new ClassB();
            //    b.Address = "Mirpur-1, Tollarbag, Dhaka";
            //    Console.WriteLine(b.Address);
            //    Console.ReadKey();
            //}



            //    //Access Modifier Protected , so call when inherit that class only show the class




        }








        //---------------------Public------------------------------------

        // class ClassA
        //{
        //    //Access Modifier Public , so call any where no problem
        //    public string Name { get; set; }
        //}
        // class ClassB
        //{
        //    //Access Modifier Public , so call any where no problem
        //    public string Address { get; set; }
        //}

        //---------------------Private------------------------------------

        //class ClassA
        //{
        //    //Access Modifier Private , so call only within the class
        //    private string Name { get; set; }
        //}
        //class ClassB
        //{
        //    //Access Modifier Private , so call only within the class
        //    private string Address { get; set; }
        //}
    }

    //---------------------Protected------------------------------------

    //    //Access Modifier Protected , so call when inherit that class only show the class
    //public class ClassA
    //{
    //    protected int Id;
    //}

    //public class ClassB:ClassA
    //{
    //    public void Print()
    //    {
    //        ClassB B = new ClassB();
    //        B.Id = 100;
    //    }
    //}


    //---------------------Internal------------------------------------
   
}
