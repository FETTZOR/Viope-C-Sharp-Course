using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
            List<int> numbers  = new List<int>();
            while (true)
            {
                Console.Write("Input a number:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input > 0)
                {
                    numbers.Add(input);
                }
                else
                {
                    Btw(numbers);
                    break;
                }
            }
        }

        public static void Btw(List<int> numbers)
        {
            Console.Write("Your input: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            } 
        }
    }


// [Serializable]
// public class numbers
// {
//     public string ASD { get; set; }
//
//     public numbers() { }
//     public numbers(string ASD, IEnumerable<int> numbers) {
//     Console.Write("Your input:");
//             foreach (int number in numbers)
//             {
//                 Console.Write(number + " ");
//             }
//     }
// }




// Input a number:101
// Input a number:121
// Input a number:1
// Input a number:-100
// Your input: 101 121 1 