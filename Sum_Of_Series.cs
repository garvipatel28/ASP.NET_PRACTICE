//Write a program to find the sum of the series 5 +55 + 555 + 5555 + .. n terms. 
//Test Data :
//Input the number of terms : 4\
//Input number : 5
//Expected Output :
//5 + 55 + 555 + 5555
//The Sum is : 6170

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Sum_Of_Series
    {
        public static void Sum_Series()
        {
            int n, num, term = 0, sum = 0;

            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num;
                sum = sum + term;

                Console.Write(term);

                if (i < n)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);

            Console.Read();

        }
    }
}
