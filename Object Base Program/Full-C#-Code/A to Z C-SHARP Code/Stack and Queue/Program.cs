using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // Stack static way
            //Stack Static way      //This is Last in fast out system
            Stack<int> aStack = new Stack<int>();
            aStack.Push(12);
            aStack.Push(1);
            aStack.Push(2);
            aStack.Push(112);
            foreach (var data in aStack)
            {
                Console.WriteLine(data);
            }


            aStack.Pop();
            Console.Write("\n=========\n");
            foreach (var item in aStack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            #endregion

            #region // Stack Dynamic way
            //Stack Static way      //This is Last in fast out system
            Stack aStack = new Stack(); //just difference without data type
            aStack.Push(12);
            aStack.Push(1);
            aStack.Push(2);
            aStack.Push(112);
            foreach (var data in aStack)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
            #endregion


            #region   // Queue static way
            Console.Write("\n=========\n");
            //Queue Static way      //This is First In First Out system
            Queue<int> aQueue = new Queue<int>();       //Queue declare
            aQueue.Enqueue(290);
            aQueue.Enqueue(291);
            aQueue.Enqueue(292);
            aQueue.Enqueue(293);
            aQueue.Enqueue(294);
            foreach (var data in aQueue)
            {
                Console.WriteLine(data);
            }


            aQueue.Dequeue();
            Console.Write("\n=========\n");
            foreach (var item in aQueue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            #endregion

            //dynamic way te problem hocee bujtace na
        }
    }
}
