using System;

namespace Declare_and_Assign4._2
{
    class Conversions
    {
        static void Main()
        {
            sbyte var1 = 127;
            Int64 var2 = 50;
            ushort var3 = 333;
            double var4 = 2.2814;
            
            if (var1.GetType() == typeof(SByte))
            {
                Console.WriteLine("var1 type ok.");
            }
            if (var2.GetType() == typeof(Int64))
            {
                Console.WriteLine("var2 type ok");
            }
            if (var3.GetType() == typeof(UInt16))
            {
                Console.WriteLine("var2 type ok");
            }
            if (var4.GetType() == typeof(Double))
            {
                Console.WriteLine("var2 type ok");
            }
            
            
        }
    }
}