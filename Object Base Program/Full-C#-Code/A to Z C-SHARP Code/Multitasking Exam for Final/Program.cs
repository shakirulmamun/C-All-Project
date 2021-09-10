using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking_Exam_for_Final
{
    class Program
    {
        private static void CreateTaskUsingAction()
        {
            Console.WriteLine("This is Action Method");
        }
        private static void CreateTaskUsingDelegate()
        {
            Console.WriteLine("This is Delegate Method");
        }
        private static void CreateTaskUsingLamdaAndNamedMethod()
        {
            Console.WriteLine("This is Lamda and Method");
        }
        private static void CreateTaskUsingLambdaAndAnonymousMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Anonymous Method.");
        }
        private static void CreateTaskUsingAsyncAwait()
        {
            Console.WriteLine("This is Async and Await Method");
        }
        private static async void CreateAsyncTask()
        {
            await Task.Run(()=> CreateTaskUsingAsyncAwait());
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static async void SolveMath(int firstInt, int secondInt)
        {
            int result = await Task.FromResult(Add(firstInt,secondInt));
            await Task.Delay(1500);
            Console.WriteLine("\nSum is = " + result.ToString());
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static async void SolveMath1(int firstInt, int secondInt)
        {
            int result = await Task.FromResult(Sub(firstInt, secondInt));
            await Task.Delay(1500);
            Console.WriteLine("\nSub is = " + result.ToString());
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static async void SolveMath2(int firstInt, int secondInt)
        {
            int result = await Task.FromResult(Multiply(firstInt, secondInt));
            await Task.Delay(1500);
            Console.WriteLine("\nMultipication is = " + result.ToString());
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static async void SolveMath3(int firstInt, int secondInt)
        {
            int result = await Task.FromResult(Division(firstInt, secondInt));
            await Task.Delay(1500);
            Console.WriteLine("\nDivision is = " + result.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task Start in Seven ways in c#");
            Console.WriteLine("\n===============================");
            Task.Factory.StartNew(() => { Console.WriteLine("Factory Method"); });
            
            Task actionTask = new Task(new Action(CreateTaskUsingAction));
            actionTask.Wait(1500);
            actionTask.Start();

            Task delegateTask = new Task(delegate { CreateTaskUsingDelegate(); });
            delegateTask.Wait(1500);
            delegateTask.Start();


            Task lamdaAndNamedMethodTask = new Task(() => CreateTaskUsingLamdaAndNamedMethod());
            lamdaAndNamedMethodTask.Wait(1500);
            lamdaAndNamedMethodTask.Start();


            Task lambdaAndAnonymousMethodTask = new Task(() => { CreateTaskUsingLambdaAndAnonymousMethod(); }); //Creating a Task using Lambda and Anonymous Method.
            lambdaAndAnonymousMethodTask.Wait(1500);
            lambdaAndAnonymousMethodTask.Start();

            CreateAsyncTask();


            Console.Write("\nFirst Number= ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("\nSecond Number= ");
            int secondInt = int.Parse(Console.ReadLine());
            Console.WriteLine("============================\n");
            SolveMath3(firstInt, secondInt);
            SolveMath2(firstInt, secondInt);
            SolveMath1(firstInt, secondInt);
            SolveMath(firstInt, secondInt);
            Console.ReadKey();

        }
    }
}
