using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region//Operator Precedence Example
            //int x = 17;
            //int y = 16;
            //int z = 4;
            //int result = x / y + z;
            //Console.WriteLine("Result1:" + result);
            //int result2 = x / y * z;
            //Console.WriteLine("Result2:" + result2);
            //bool result3 = z <= x + y;
            //Console.WriteLine("Result3:" + result3);
            //Console.ReadKey();
            #endregion

            #region //Assignment Operator
            //int num1 = 5;
            //int num2=7;
            //num1 += num2;   //same as num1=num1+num2
            //Console.WriteLine("Sum:" +num1);
            //num1 -= num2;   //same as num1=num1-num2
            //Console.WriteLine("Substruction:" + num1);
            //num1 *= num2;   //same as num1=num1*num2
            //Console.WriteLine("Multipication:" + num1);
            //num1 /= num2;   //same as num1=num1/num2
            //Console.WriteLine("Dividation:" + num1);
            //num1 %= num2;   //same as num1=num1%num2
            //Console.WriteLine("Modulus:" + num1);
            //Console.ReadKey();
            #endregion

            #region  //Ternary Operator
            int m = 30, n = 20;
            //var result = m > n ? "m greter than n" : "m less than n";
            //Console.WriteLine(result);
            //Console.ReadKey();
            
            
            //Same as above part
            if (m>n)
            {
                Console.WriteLine("m greter than n");
            }
            else
            {
                Console.WriteLine("m less than n");
            }
            Console.ReadKey();
            #endregion

            #region  //Increment & Decrement Operator
            //Increment

            //int i = 3;
            //i++;    //post increment
            //Console.WriteLine("The value of i is: {0}",i);
            //Console.ReadKey();

            //Decrement

            //int j = 3;
            //Console.WriteLine("The value of j is: {0}", j);
            //j--;    //post Decrement
            //Console.WriteLine("The value of j is now: {0}", j);
            //Console.ReadKey();

            #endregion

            #region  //Comperison Operator
            //int num1, num2;

            ////Accepting two inputs from the user
            //Console.Write("Enter first number\t");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number\t");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Processing comparison
            //Check whether num1 is greater than or not
            //if (num1 > num2)
            //{
            //    Console.WriteLine("{0} is greater than {1}", num1, num2);
            //}
            ////Check whether num2 is greater than or not
            //else if (num2 > num1)
            //{
            //    Console.WriteLine("{0} is greater than {1}", num2, num1);
            //}
            //else
            //{
            //    Console.WriteLine("{0} and {1} are equal", num1, num2);
            //}
            //Console.ReadLine();
            #endregion

            #region  //Logical Operator

            //string username="shakirulmamun125@gmail.com";
            //int passward=123;
            //if (username== "shakirulmamun125@gmail.com" && passward==123)
            //{
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("!opps Login failed");
            //}
            //Console.ReadKey();

            #endregion

            #region  //Vowel Check Use LOGICAL OPERATOR

            //char ch;
            //Console.Write("Enter your character : ");
            //ch = Convert.ToChar(Console.ReadLine());
            //if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U') 
            //{
            //    Console.WriteLine("This is Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("This is not Vowel");
            //}
            //Console.ReadKey();

            #endregion

            #region //Calculate area of Rectangle

            int height, width, area;

            Console.Write("Enter 1st Value: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd Value: ");
            width = Convert.ToInt32(Console.ReadLine());

            area = height * width;
            Console.WriteLine("Area is:" +area);
            Console.ReadKey();
            #endregion

        }
    }
}
