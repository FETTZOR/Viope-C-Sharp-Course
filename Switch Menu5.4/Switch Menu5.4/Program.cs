using System;

namespace Switch_Menu5._4
{
    class SwitchMenu
    {
        static void Main()
        {
            int input;

            Console.WriteLine("Please select:" + "\n1) Water" +
            "\n2) Juice" +
            "\n3) Lemonade" +
            "\n4) Quit");
            input = Convert.ToInt16(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("You selected Water.");
                    break;

                case 2:
                    Console.WriteLine("You selected Juice.");
                    break;
                
                case 3:
                    Console.WriteLine("You selected Lemonade.");
                    break;
                case 4:
                    Console.WriteLine("Quit!");
                    break;
            }
        }
    }
}

// Please select:
// 1) Water
// 2) Juice
// 3) Lemonade
// 4) Quit
// 4
// Quit!