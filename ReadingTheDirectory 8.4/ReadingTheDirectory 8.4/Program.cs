using System;
using System.IO;

namespace ReadingTheDirectory_8._4
{
    class Program
    {
        static void Main()
        {
            string path = ".";
            string[] dirList = Directory.GetFiles(path, ".");

            if (dirList.Length > 0)
            {
                foreach (string fileName in dirList)
                {
                    Console.WriteLine(fileName);
                }
            }
        }
    }
}
// ./a.out
// ./program.cs
// ./foo.txt
// ./bar.txt
// ./3.txt
// ./2.txt
// ./1.txt