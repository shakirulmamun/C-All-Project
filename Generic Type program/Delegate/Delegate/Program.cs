using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void MyDelegate(string message);   //delegate method declare
        public static void MyMethod(string msg)     //simple method declare
        {
            Console.WriteLine(msg);
        }
        static void MyMethodWithCallbak(int param1, int param2, MyDelegate Callback)    //callback method declare
        {
            Callback("Number is: " + (param1 + param2).ToString()); //callback parameter e return kore
        }
        static void Main(string[] args)
        {
            MyDelegate handle = MyMethod;   //handle er maddome call
            handle("First Delegate Test");
            MyMethodWithCallbak(2, 3, handle);  ////Callback er maddome Value pass
            Console.ReadKey();
        }
      
    }

 
}
