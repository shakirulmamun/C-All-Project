using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region   // Array Declare Way
            //// Declaring and Initializing an array with size of 5
            //int[] array = new int[5];
            ////Defining and assigning an elements at the same time
            //int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
            ////Initialize with 5 elements will indicates the size of an array
            //int[] array3 = new int[] { 1, 2, 3, 4, 5 };
            //// Another way to initialize an array without size
            //int[] array4 = { 1, 2, 3, 4, 5 };
            //// Declare an array without initialization
            //int[] array5;
            //array5 = new int[] { 1, 2, 3, 4, 5 };
            //#endregion

            //#region ///      Array declare
            //int[] arrays = new int[6] { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(arrays[0]);
            //Console.WriteLine(arrays[1]);
            //Console.WriteLine(arrays[2]);
            //Console.WriteLine(arrays[3]);
            //Console.WriteLine(arrays[4]);
            //Console.WriteLine(arrays[5]);
            //Console.ReadKey();
            //#endregion

            //#region   //  Array with for loop use just show length properth
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("Exit");
            //Console.ReadKey();
            //#endregion

            //#region  // Array with foreach loop use just show length properth
            //int[] arraysss = new int[3] { 1, 2, 3 };
            //foreach (int p in arraysss)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.ReadKey();
            //#endregion

            //#region  //Signle Dimensional Array

            //int[] ara = { 1, 2, 3, 4 };
            //for (int i = 0; i < ara.Length; i++)
            //{
            //    Console.WriteLine(ara[i]);
            //}
            //Console.ReadKey();
            //#endregion

            //#region  //  //Multi Dimensional Array
            //int[,] are = new int[3, 3];
            //are[0, 1] = 20;
            //are[1, 2] = 30;
            //are[2, 0] = 40;
            //for (int g = 0; g < 3; g++)
            //{
            //    for (int h = 0; h < 3; h++)
            //    {
            //        Console.WriteLine(are[g, h]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //#endregion

            //#region  // Jagged Array
            //int[][] ar = new int[3][];
            //ar[0] = new int[] { 20, 21, 22, 34, 54 };
            //ar[1] = new int[] { 88, 66, 55, 44, 33 };
            //ar[2] = new int[] { 32, 43, 55, 67, 7 };
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    for (int k = 0; k < ar[i].Length; k++)
            //    {
            //        Console.WriteLine(ar[i][k] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //#endregion

            Student<string> s = new Student<string>() { Name = "mamun", Age = "Twenty" };
            Student<int> s1 = new Student<int>() { Name = 12, Age =11 };
            Console.WriteLine(s.Name,s.Age);
            //Console.WriteLine(s1.Age, s1.Name);
            Console.ReadKey();
        }

        public class Student<T>
        {
            public T Name { get; set; }
            public T Age { get; set; }
        }
    }
}
