//* * * * *
//* * * * *
//* * * * *
//* * * * *
//* * * * *

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Star_Pattern3
    {
        public static void pattern3()
        {
            for (int i = 1; i <= 5; i++)   //for rows
            {
                for (int j = 1; j <= 5; j++)     //for columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
