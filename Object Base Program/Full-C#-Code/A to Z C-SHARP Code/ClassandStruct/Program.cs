using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandStruct
{
    class Program
    {
        //***********Difference between Class & Struct Start*******

        //The output will be 20. Value of "b" is a copy of "a", so "b" is unaffected by change
        //of "a.x". But in class, the output will be 100 because "a" and "b"
        //will reference the same object.

        //আউটপুট হবে 20. "b" এর মান "a" এর অনুলিপি, সুতরাং "b" "a.x" পরিবর্তনের দ্বারা প্রভাবিত হয় না।
        //তবে ক্লাসে আউটপুট 100 হবে কারণ "a" এবং "b" একই অবজেক্টকে রেফারেন্স করবে।

        //***********Difference between Class & Struct End *******
        static void Main(string[] args)
        {
            ////***********When Insted class of Struct *******
            /////এখানে struct যেহুতু value type সেহুতু a.x=100 মান assign করা আছে সেটার মান না নিয়ে প্রথমের যে মান ২০ আছে সেটি b তে copy হবে।
            //তার মানে b এর মান ও ২০ হবে।
            //Location a = new Location(20, 20);
            //Location b = a;
            //a.x = 100;
            ////Console.WriteLine(a.x);
            //Console.WriteLine(b.x);
            //Console.ReadKey();

            //***********When Insted Struct of class   *******
            //এখানে ক্লাস যেহুতু reference type সেহুতু c.x=100 মান assign করা আছে সেটা পুরোটাই d তে copy হবে।
            //তার মানে d এর মান ও ১০০ হবে।
            Location1 c = new Location1(20, 20);
            Location1 d = c;
            c.x = 100;
            Console.WriteLine(c.x);
            Console.WriteLine(d.x);
            Console.ReadKey();
        }
    }
    //struct Location
    //{
    //    public int x, y;
    //    public Location(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}

    //***********When class Declare  *******
    class Location1
    {
        public int x, y;
        public Location1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
