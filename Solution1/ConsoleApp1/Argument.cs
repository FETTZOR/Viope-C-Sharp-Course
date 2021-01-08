using System;

namespace ConsoleApp1
{
    class Argument
    {
        static void Main(string[] args)
        {
             
            // To check the length of  
            // Command line arguments   
            if(args.Length > 0) 
            { 
                Console.WriteLine("Arguments Passed by the Programmer:");   
              
                // To print the command line  
                // arguments using foreach loop 
                foreach(Object obj in args)   
                {   
                    Console.WriteLine(obj);        
                }   
            }   
              
            else
            { 
                Console.WriteLine("No command line arguments found."); 
            } 
        } 
    }
}
//Write a C# program which prints out the first provided command line argument.
//You can assume the argument is always provided and consists of letters and digits.
//The command line argument was: AnotherTestArgument