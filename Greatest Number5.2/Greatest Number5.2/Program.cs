using System;

namespace Greatest_Number5._2 

{
    class GreatestNumber
    {
        static void Main()
        { 
            
            Console.WriteLine("Please input the first number: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number: ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Number 1 is greater than number 2.");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("Numbers are equal.");
            }
            else
            {
                Console.WriteLine("Number 2 is greater than number 1.");
            }
        }
    }
}