using System;

namespace SummingInputs6._2
{
    class Metropolia
    {
        static void Main()
        {
            int i = 0;
            int sum = 0;
            
            while (true)
            {
                Console.Write("Sum is now " + sum + ". Input: " );
                i = Convert.ToInt32(Console.ReadLine());
                sum = sum + i;
                if (sum >= 200)
                {
                    Console.WriteLine("Reached 200." + " The total was " + sum + ".");
                    break;
                }
            }
        }
    }
}


// Sum is now 0. Input: 99
// Sum is now 99. Input: 1
// Sum is now 100. Input: 98
// Sum is now 198. Input: 5
// Reached 200. The total was 203.