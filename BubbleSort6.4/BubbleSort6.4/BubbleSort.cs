using System;

namespace BubbleSort6._4
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] intArgs = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                if (!int.TryParse(args[i], out intArgs[i]))
                { 
                    return;
                }
            }

            for (int i = 0; i <= intArgs.Length - 1; i++)  
            {  
                
                for (int j = i + 1; j < intArgs.Length; j++)  
                {
                    if (intArgs[i] > intArgs[j])  
                    {  
                        var temp = intArgs[i];  
                        intArgs[i] = intArgs[j];  
                        intArgs[j] = temp;  
                    }  
                }  
            }
            foreach (var item in intArgs)  
            {  
                Console.Write(item + " ");  
            }
        }  
    }
}
// Bubble sort is the simplest sorting algorithm, which orders given values from smallest to biggest. The pseudocode is the following:
//
// for i from 1 to N
// for j from 0 to N-1
// if a[j]>a[j+1]
// swap(a[j], a[j+1])
// // 1 9 10 12 99 
// Write a C# program which implements bubble sort. The program gets the values as command line arguments.
//
// Hint: prepare an int array with the same size as string args length
// (use args.Length). Use foreach statement to traverse through all arguments and use int.
// Parse(argument) to convert the data to int and assign to the prepared int array.
//
