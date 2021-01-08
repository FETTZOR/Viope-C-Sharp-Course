using System;

namespace Repeating_Numbers6._1
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);
            for (int i = 1; i <= n; i++)
            {
                int arg;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n\r");
            }
        }
    }
}
// Console.WriteLine("1");
// Console.Write("\r1"+""+"2");
// Console.Write("\n\r1"+""+"2" + "3");
// Console.Write("\n\r1"+""+"2" + "3" + "4");
// Console.Write("\n\r1"+""+"2" + "3" + "4" + "5");
// Console.Write("\n\r1"+""+"2" + "3" + "4" + "5" + "6");
// Console.Write("\n\r1"+""+"2" + "3" + "4" + "5" + "6" + "7");
// Console.Write("\n\r1"+""+"2" + "3" + "4" + "5" + "6" + "7" + "8");