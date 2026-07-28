//Write a program to display a pattern like a diamond. 

//    *  

//   ***   

//  *****

// *******

//*********  

// ******* 

//  *****  

//   ***   

//    *

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Diamond_Pattern
    {
        public static void diamond()
        {
            // Upper Half
            for (int i = 1; i <= 5; i++)
            {
                // Print spaces
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower Half
            for (int i = 4; i >= 1; i--)
            {
                // Print spaces
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
