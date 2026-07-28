//1
//1 2
//1 2 3
//1 2 3 4

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Num_Pattern1
    {
        public static void pattern1()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            Console.Read();


        }
    }
}
