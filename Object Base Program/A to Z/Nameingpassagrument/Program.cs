using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgrumentPass
{
    class Program
    {
        static void Main(string[] args)
        {

            //StudentInfo(roll_No: 4, name: "Md. Shakirul Mamun",id : 1, course: "C#");
            StudentInfo("Shakirul", "Mamun");
            //StudentInfo(name: "Md. Shakirul Mamun", roll_No: 44, id: 21, course: "PHP");
            Console.ReadLine();
            Console.ReadKey();
        }
        public static void StudentInfo(string FN, string LN)
        {
            Console.WriteLine("Roll No: { 0}, { 1}", FN, LN);
        }
       

    }
}
