using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Compatible_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "1";     //This is non compatible data types
            ////int i = Convert.ToInt32(s);  //string to intger a convert
            //int j = int.Parse(s);         //string to intger a convert
            //Console.WriteLine(s);
            //Console.ReadKey();


            //........Range find out..............
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            //Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
            //Console.WriteLine("{0} {1}", decimal.MinValue, decimal.MaxValue);
            //Console.ReadKey();



            //............Try catch use................

            //float f = 34.7f;
            //int i = (int)f;
            //Console.WriteLine(i);
            //Console.ReadKey();


            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");

            }
            Console.ReadKey();
        }
       
    }
}
