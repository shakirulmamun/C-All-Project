using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    class Program
    {
    
        static void Main(string[] args)
        {
           
            double num1 = 30.90;
            double num2 = 20.20;
            double answer;
            string operators;

            Console.WriteLine(" \t\t\t\t\t Calculator\n \t\t\t\tCreate by Md. Shakirul Mamun\n ");

            Console.WriteLine("Type First number and press Enter\n\n ");
            num1 = double.Parse(Console.ReadLine());

     
            Console.WriteLine("Select any operator:( +,-,*,/,%)\n\n");
            operators = (Console.ReadLine());

            Console.WriteLine("Type anothoer number and press Enter\n\n");
            num2 = double.Parse(Console.ReadLine());
            
            if (operators == "+")
                {
                answer = num1 + num2;
                Console.Write("\n" + answer);
            }
            if (operators == "-")
            {
                answer = num1 - num2;
                Console.Write("\n" + answer);
            }
            if (operators == "*")
            {
                answer = num1 * num2;
                Console.Write("\n" + answer);
            }
            if (operators == "/")
            {
                answer = num1 / num2;
                Console.Write("\n" + answer);
            }
            if (operators == "%")
            {
                answer = num1 % num2;
                Console.Write("\n Total= " +answer);
                
            }

            Console.WriteLine("\n\n\t\t\t" + "Press any key to Exit...................");

            Console.ReadKey();
        





        }
    }
}
