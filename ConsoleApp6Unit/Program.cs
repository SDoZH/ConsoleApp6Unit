using System;

namespace ConsoleApp6Unit
{
   class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

}