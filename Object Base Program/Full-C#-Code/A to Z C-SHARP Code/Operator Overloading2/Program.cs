using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading2
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }

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
}
