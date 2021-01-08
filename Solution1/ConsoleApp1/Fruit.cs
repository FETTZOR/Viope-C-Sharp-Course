using System;

namespace ConsoleApp1
{
    class Fruit
    {
        static void Main()
        {
            string answer;
        
            Console.Write("What is your favourite fruit? ");
            answer = Console.ReadLine();
            Console.WriteLine("Your favourite fruit is " + answer);
        }
    }
}

// What is your favourite fruit? Banana
// Your favourite fruit is Banana