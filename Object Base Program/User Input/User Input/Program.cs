using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your User Name: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is : " + age);
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Text Length is: " + txt.Length);
            Console.WriteLine("Thank You");
            Console.ReadKey();

        }
    }
}
