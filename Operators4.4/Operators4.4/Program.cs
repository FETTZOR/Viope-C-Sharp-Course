using System;

namespace Operators4._4
{
    class Program
    {
        static void Main()
        {
            byte x = 1;
            byte y = 1;
            byte z = 3;
            String s = "C";
            
            if (((x >= y) && (y < z)) || ((x > y)  && (s == "A")) )
            {
                if (s == "C")
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Almost there!");
                }
            }
        }
    }
}