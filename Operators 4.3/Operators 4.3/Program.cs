using System;

namespace Operators_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 0;
            
            if ((a != b) && (a < b))
            {
                if (a > c)
                {
                    Console.WriteLine("Success");
                }
            }
            else
            {
                Console.WriteLine("Try once more!");
            }
        }
    }
}