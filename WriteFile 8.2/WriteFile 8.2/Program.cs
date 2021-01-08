using System;
using System.IO;

namespace WriteFile_8._2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Filename to create: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Provide the content for " + fileName + ": \n");
            string content = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(content);
            }
        }
    }
}
// Filename to create: bar.txt
// Provide the content for bar.txt:
// Another line of test content