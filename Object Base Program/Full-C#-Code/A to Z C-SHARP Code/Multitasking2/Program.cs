using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking2
{
    class Program
    {
        static void Main(string[] args)
        {
            File f = new File();
            Task t = new Task(f.Copy);
            t.Start();
            Console.WriteLine("Main Thread Ended");
            Console.ReadKey();
        }
    }

    class File
    {
        public void Copy()
        {
            Console.WriteLine("File Copy.........");
            FileStream inStream = new FileStream(@"E:\DumyFile.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            FileStream OutStream = new FileStream(@"DumyFileCopy.txt",FileMode.Create, FileAccess.Write, FileShare.Read);
            using (inStream)
            {
                while (true)
                {
                    int b = inStream.ReadByte();
                    if (b==-1)
                    {
                        break;
                    }
                    OutStream.WriteByte((byte)b);
                }
            }
            Console.WriteLine("File Coppied.......");
        }
    }
}
