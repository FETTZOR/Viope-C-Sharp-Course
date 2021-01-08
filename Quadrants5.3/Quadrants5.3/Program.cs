using System;

namespace Quadrants5._3
{
    class Program
    {
        static void Main()
        {
            int x,y;

            Console.WriteLine("Find the quadrant for a point in x-y axis: ");
            Console.Write("X coordinate: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y coordinate: ");
            y = Convert.ToInt32(Console.ReadLine());

            if( x > 0 && y > 0)
                Console.WriteLine("The coordinate point" + " (" + x + "," + y +") " + "is in the First quandrant." );
            else if( x < 0 && y > 0)
                Console.WriteLine("The coordinate point" + " (" + x + "," + y +") " + "is in the Second quandrant.");
            else if( x < 0 && y < 0)
                Console.WriteLine("The coordinate point" + " (" + x + "," +y +") " + "is in the Third quandrant.");
            else if( x > 0 && y < 0)
                Console.WriteLine("The coordinate point" + " (" + x + "," + y +") " + "is in the Fourth quandrant.");
            else if( x == 0 && y == 0)
                Console.WriteLine("The coordinate point " + " (" + x + "," + y +") " + "is at the origin.");
        }
    }
}

// Find the quadrant for a point in x-y axis:
// X coordinate: 0
// Y coordinate: 0
// The coordinate point (0,0) is at the origin.