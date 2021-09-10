using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Call
{
    class Program
    {
        static void Main(string[] args)
        {

            UserGetName();
            Console.WriteLine("== Exit ==");
            //Program em = new Program();
            //string result = em.UserGetName("Md. Shakirul Mamun", 24);
            //string infos= em.UserGetName("Sawon", 12);
            //Console.WriteLine(result,infos);
            Console.ReadKey();

        }
            public static void UserGetName()
            //public static void UserGetName(string name, int age)
        {
            string name= "Md. Shakrul Mamun";
            int age=32;
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
            //string info = string.Format("Name: {0}, Age: {1}", name, age);
            //return info;
        }
    }
}
