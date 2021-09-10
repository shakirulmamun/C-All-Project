using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(100, "Mamun");
            st.PrintDetails();
            Console.ReadKey();
        }
    }
    public struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void PrintDetails()
        {
            Console.WriteLine("ID = {0} & Name = {1}", Id, Name);
            
        }
    }
}
