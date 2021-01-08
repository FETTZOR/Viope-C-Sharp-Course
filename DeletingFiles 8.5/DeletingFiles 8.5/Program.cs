using System;
using System.IO;
using System.IO.Compression;

namespace DeletingFiles_8._5
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            string path = "";
            string[] dirList = Directory.GetFiles(path, ".dat");
            foreach (var fileName in dirList)
            {
                File.Delete(fileName);
                count++;
            }
            Console.Write(count + " file(s) deleted.");
        }
    }
}
// 3 file(s) deleted.