using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
            a.Add();
            Console.Read();
        }
        static void EventMessage()
        {
            Console.WriteLine("********Event Executed : This is Odd Number**********");
        }
        class AddTwoNumbers
        {
            public delegate void dg_OddNumber();
            public event dg_OddNumber ev_OddNumber;

            public void Add()
            {
                int result;
                result = 0 + 3;
                Console.WriteLine(result.ToString());
                if ((result % 2 != 0) && (ev_OddNumber != null))
                {
                    ev_OddNumber();

                }
            }
        }

        
    }

    
}
