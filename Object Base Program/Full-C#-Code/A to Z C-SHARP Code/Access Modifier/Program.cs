using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    class Program //: ProtectedInternal //:Protected     //protected class use hoy only tar child class a (ai khane child class holo program)
    {
        static void Main(string[] args)
        {
            //Public Example
            //Public pc = new Public();   //instance create hoy class er opor depend korea
            //Console.Write("Enter your Name: ");     //user er kacea input neya hoice
            //pc.name = Console.ReadLine();   //string hisabea dekanor jonno 
            //pc.print();     //print method k call kora hoice
            //Console.ReadKey();


            //Private Example
            //Private pt = new Private();   //instance create hoy class er opor depend korea
            //Console.Write("Enter your Name: ");     //user er kacea input neya hoice

            //// raise error because of its protection level

            //pt.name = Console.ReadLine();   //DON'T CALL VARIABLE because name is private
            //pt.print();     
            //Console.ReadKey();


            //PROTECTED Example

            //Program p = new Program();
            //Console.Write("Enter your Name: ");
            //p.name = Console.ReadLine();
            //p.print();
            //Console.ReadKey();



            //Internal Example

            //Internal inter = new Internal();
            //Console.Write("Enter your Name: ");
            //inter.name = Console.ReadLine();
            //inter.print();
            //Console.ReadKey();


            //Protected Internal Example  //:::: ata internal er moto use hoy and inherit (derive) koreao use kora jay 

            //Program inter = new Program();
            //Console.Write("Enter your Name: ");
            //inter.name = Console.ReadLine();
            //inter.print();
            //Console.ReadKey();


        }

    }
    #region Public Example
    //class Public
    //{
    //    public string name; //only declare variable

    //    public void print()
    //    {
    //        Console.WriteLine("Your name is: " + name);
    //    }
    //}
    #endregion

    #region Private Example
    //class Private
    //{
    //    private string name; //only declare variable

    //    public void print1()
    //    {
    //        Console.WriteLine("Your name is: " + name);
    //    }
    //}
    #endregion

    #region  Protected Example
    //class Protected
    //{
    //    protected string name;

    //    public void print()
    //    {
    //        Console.WriteLine("My name is: " +name);
    //    }
    //}

    #endregion

    #region  Internal Example
    //class Internal
    //{
    //    internal string name;

    //    public void print()
    //    {
    //        Console.WriteLine("My name is: " + name);
    //    }
    //}

    #endregion

    #region  Protected Internal Example
    //class ProtectedInternal
    //{
    //    protected internal string name;

    //    public void print()
    //    {
    //        Console.WriteLine("My name is: " + name);
    //    }
    //}

    #endregion


}
