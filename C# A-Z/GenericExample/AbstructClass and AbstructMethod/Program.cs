using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClass_and_AbstructMethod
{

    public abstract class Student   //Abstruct Class
    {
        public abstract void PrintFullName();     //Abstruct Member
        public void PrintFullName1()        //Non-Abstruct Member .....ata memdetory na ata use korlea must implement kortea hobe
        {
            Console.WriteLine("Hello");
        }
    }
    class Program:Student
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Mamun");
        }
        static void Main(string[] args)
        {
            Program pt = new Program();
            pt.PrintFullName();
            pt.PrintFullName1();
            Console.ReadKey(); 
        }
        
        
    }
}
