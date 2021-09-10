using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IStudent       //Create interface IStudent 1. no return type, 2. only return method
    {
        void GetId();
        void SetId();
        void PrintFull();
    }
    public interface ISubject
    {
        void PrintFullName();
    }
    public interface ISubjectOne
    {
        void PrintFullName();        //ISubject & Isubject1 er method same atai explicit method
    }
    public class Student:IStudent,ISubject,ISubjectOne
    {
        public void PrintFull()  
        {
            Console.WriteLine("Hello.....");
        }
        public void GetId()
        {
            Console.WriteLine();
        }

        public void SetId()
        {
            throw new NotImplementedException();
        }

         void ISubject.PrintFullName()
        {
             Console.WriteLine("Hello");
        }
        void ISubjectOne.PrintFullName()
        {
            Console.WriteLine("Hi");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();   //instance create for Derived class
            //st.PrintFull();
            //((IStudent)st).PrintFull();    //Explicitly method er jonno
            ((ISubject)st).PrintFullName();     //Explicitly method ISubject er jonno ...Ata Interface partern variable
            ((ISubjectOne)st).PrintFullName();  //Explicitly method ISubjectOne er jonno
            Console.ReadKey();
            
        }
    }
}
