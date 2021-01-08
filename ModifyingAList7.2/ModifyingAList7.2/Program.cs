using System;
using System.Collections.Generic;

namespace ModifyingAList7._2
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string> {"Torvalds", "Musk", "Gates", "Buffet", "Dorsey"};
            names.RemoveAt(0);
            names.RemoveAt(1);
            names.RemoveAt(2);
            names.Insert(0, "Jobs");
            names.Insert(2, "McAfee");
            names.Insert(4, "Wozniak");
            
            // Jobs, Musk, McAfee, Buffet, Wozniak.

            foreach (string name in names)
            {
              Console.WriteLine(name);  
            }
        }
    }
}