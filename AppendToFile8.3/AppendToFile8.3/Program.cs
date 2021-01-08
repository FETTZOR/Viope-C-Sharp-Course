using System;
using System.IO;

namespace AppendToFile8._3
{
    class AppendToFile
    {
        static void Main()
        {
            Console.Write("Append to file: ");
            string fileName = Console.ReadLine();
            Console.Write("Provide the content for " + fileName + ":\n");
            string content = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(content);
            }
        }
    }
}
// Append to file: foobar.txt
// Provide the content for foobar.txt:
// More test content for 2nd assessment