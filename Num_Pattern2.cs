//The pattern like :

//1

//2 3

//4 5 6

//7 8 9 10

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Num_Pattern2
    {
        public static void pattern2()
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
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
