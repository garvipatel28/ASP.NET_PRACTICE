//   *
//  * *
// * * *
//* * * *

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Star_Pattern2
    {
        public static void pattern2()
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
