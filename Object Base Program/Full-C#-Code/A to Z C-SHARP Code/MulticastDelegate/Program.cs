using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        public delegate void ShowMessage(string s);
        public void message1(string msg)
        {
            Console.WriteLine("1st Message is : {0}", msg);
        }
        public void message2(string msg)
        {
            Console.WriteLine("2nd Message is : {0}", msg);
        }
        public void message3(string msg)
        {
            Console.WriteLine("3rd Message is : {0}", msg);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program.ShowMessage message = null;
            message += new Program.ShowMessage(p.message1);
            message += new Program.ShowMessage(p.message2);
            message += new Program.ShowMessage(p.message3);
            message("Hello mamun");
            Console.WriteLine("----------------------");
            message -= new Program.ShowMessage(p.message2);
            message("Message 2 Removed");
            Console.ReadKey();
        }
       
    }
   
}
