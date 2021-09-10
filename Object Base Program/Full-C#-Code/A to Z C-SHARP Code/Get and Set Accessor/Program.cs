using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_Set_Accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            input i = new input();
            Console.Write("Enter your 1st Number: \t");
            i.number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your 2nd Number: \t");
            i.number2 = Convert.ToInt32(Console.ReadLine());
            i.print();
            Console.ReadKey();
        }
    }

    class input
    {
        int num1, num2, result;
        public void print()
        {
            result = num1 + num2;
            Console.WriteLine("Your result is: "+result);
            Console.ReadKey();

        }
        public int number1
        {
            get
            {
                return num1;
            }
            set
            {
                 num1=value;
            }
        }
        public int number2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }
    }
}
