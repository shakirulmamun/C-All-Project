using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> func1 = x => x + 4;
            Console.WriteLine("Input a Number : ");
            int i = Int32.Parse(Console.ReadLine());

            // Use lambda expression with statement body.
            //
            Func<int, int> func2 = x => { return x + 1; };        //3

            // Use formal parameters with expression body.

            Func<int, int> func3 = (int x) => x + 1;        //2

            // Use parameters with a statement body.
            //
            Func<int, int> func4 = (int x) => { return x + 1; };   //2

            //Use multiple parameters.

            Func<int, int, int> func5 = (x, y) => x - y;        //0

            // Use no parameters in a lambda expression.
            //
            Action func6 = () => Console.WriteLine();   //only space
           
            // Use delegate method expression.
             //
             Func<int, int> func7 = delegate (int x) { return x + 1; };  //2
              //
             // Use delegate expression with no parameter list.
             //
            Func<int> func8 = delegate { return 1 + 1; };   //2

            //Invoke each of the lambda expressions and delegates we created.
            // ... The methods above are executed.

            Console.WriteLine(func1.Invoke(i));
            Console.WriteLine(func1.Invoke(1));
            Console.WriteLine(func2.Invoke(1));
            Console.WriteLine(func3.Invoke(1));
            Console.WriteLine(func4.Invoke(1));
            Console.WriteLine(func5.Invoke(2, 2));
            func6.Invoke();
            Console.WriteLine(func7.Invoke(1));
            Console.WriteLine(func8.Invoke());
            Console.ReadKey();
        }

    }
}
