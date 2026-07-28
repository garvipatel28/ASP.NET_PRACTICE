using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Fibbonacci
    {
        public static void fibbo_series()
        {
            int a = 0, b = 1, c;

            Console.Write(a + " ");
            Console.Write(b + " ");

            for (int i = 1; i <= 9; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.Read();

        }
    }
}
