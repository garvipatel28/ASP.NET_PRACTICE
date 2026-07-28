//The pattern like :

//*

//**

//***

//****

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Star_Pattern1
    {
        public static void pattern1()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Read();

        }

    }
}
