//    1
//   2 3
//  4 5 6
//7 8 9 10

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Num_Pattern3
    {
        public static void pattern3()
        {
            int rows = 4;
            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print numbers
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
