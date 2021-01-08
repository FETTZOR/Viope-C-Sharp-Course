using System;

namespace CommandLineArgument3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The command line argument was: ");
            Console.Write(args[0]);
            Console.WriteLine(args[1]);
        }
    }
}

// The command line argument was: AnotherTestArgument