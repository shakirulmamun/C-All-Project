using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast
{
    delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate sm = new SampleDelegate(SampleMethod);
            SampleDelegate sm1 = new SampleDelegate(SampleMethodOne);
            SampleDelegate sm2 = new SampleDelegate(SampleMethodTwo);
            SampleDelegate sm3 = new SampleDelegate(SampleMethodThree);
            
            SampleDelegate sm4 = sm + sm1 + sm2 + sm3;
            sm4();

            //SampleDelegate sm4 = sm;
            //sm4 += sm1;
            //sm4 += sm2;
            //sm4 -= sm3;     //remove
            //sm4();

            Console.ReadKey();
        }
        public static void SampleMethod()
        {
            Console.WriteLine("Message");
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("Message1");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("Message2");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Message3");
        }
    }
}
