using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class OddEven
    {
        public static void oddeven()
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd.");
            }
        }
    }
}

