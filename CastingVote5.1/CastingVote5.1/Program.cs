using System;

namespace CastingVote5._1
{
    class castingVote
    {
        static void Main()
        {
            int input;
            Console.WriteLine("Please input your age: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 18)
            {
                Console.WriteLine("You can cast your vote!");
            }
        }
    }
}

// Please input your age: 
// 32
// You can cast your vote!