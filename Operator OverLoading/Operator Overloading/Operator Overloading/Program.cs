using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------Use Operator Overloading (Increment & Decrement)--------------

            Console.WriteLine("============Increment===========");
            Operoverload ov1 = new Operoverload(5);
            Operoverload ov2 = ov1++;
            Console.WriteLine(ov1.i);
            Console.WriteLine(ov2.i);
            ov2 = ++ov1;
            Console.WriteLine(ov1.i);
            Console.WriteLine(ov2.i);

            Console.WriteLine("===========Decrement============");
            Operoverload ov3 = new Operoverload(3);
            Operoverload ov4 = --ov3;
            Console.WriteLine(ov3.i);
            Console.WriteLine(ov4.i);
            ov4 = --ov3;
            Console.WriteLine(ov3.i);
            Console.WriteLine(ov4.i);
            Console.Read();

            //--------Use Operator Overloading (Sum, Sub, Multiply, Division, Modulus)--------------
            //Calculator num1 = new Calculator(100);
            //Calculator num2 = new Calculator(30);
            //Calculator num3 = new Calculator();
            //Calculator num4 = new Calculator();
            //Calculator num5 = new Calculator();
            //Calculator num6 = new Calculator();
            //Calculator num7 = new Calculator();
            //num3 = num1 + num2;
            //num4 = num1 - num2;
            //num5 = num1 * num2;
            //num6 = num1 / num2;
            //num7 = num1 % num2;
            //Console.Write("1st Number: ");
            //num1.display();
            //Console.Write("2nd Number: ");
            //num2.display();
            //Console.Write("Sumation is: ");
            //num3.display();
            //Console.Write("Substruction is: ");
            //num4.display();
            //Console.Write("Multipication is: ");
            //num5.display();
            //Console.Write("Division is: ");
            //num6.display();
            //Console.Write("Modulus is: ");
            //num7.display();
            //Console.ReadKey();

        }
    }

    //--------Use Operator Overloading (Increment & Decrement)--------------
    class Operoverload
    {
        public int i;
        public Operoverload(int a)
        {
            this.i = a;
        }
        public static Operoverload operator ++(Operoverload Serial)
        {
            Serial.i++;
            return Serial;
        }
        public static Operoverload operator --(Operoverload Serial)
        {
            Serial.i--;
            return Serial;
        }


    }

    //--------Use Operator Overloading (Sum, Sub, Multiply, Division, Modulus)--------------

    //class Calculator
    //{
    //    public double result = 0;
    //    public Calculator()
    //    {

    //    }
    //    public Calculator(double x)
    //    {
    //        result = x;
    //    }
    //    public static Calculator operator +(Calculator a, Calculator b)
    //    {
    //        Calculator c = new Calculator(0);
    //        c.result = a.result + b.result;
    //        return c;
    //    }
    //    public static Calculator operator -(Calculator a, Calculator b)
    //    {
    //        Calculator c = new Calculator(0);
    //        c.result = a.result - b.result;
    //        return c;
    //    }
    //    public static Calculator operator *(Calculator a, Calculator b)
    //    {
    //        Calculator c = new Calculator(0);
    //        c.result = a.result * b.result;
    //        return c;
    //    }
    //    public static Calculator operator /(Calculator a, Calculator b)
    //    {
    //        Calculator c = new Calculator(0);
    //        c.result = a.result / b.result;
    //        return c;
    //    }
    //    public static Calculator operator %(Calculator a, Calculator b)
    //    {
    //        Calculator c = new Calculator(0);
    //        c.result = a.result % b.result;
    //        return c;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine("{0}", result);
    //        //Console.WriteLine("==============================");
    //    }
    //}
}
