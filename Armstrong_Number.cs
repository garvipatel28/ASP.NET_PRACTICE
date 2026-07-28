//Write a Program to check whether the given no is Armstrong no or not.

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Armstrong_Number
    {
        public static void armstrong()
        {

            int num, temp, rem, sum = 0;

            Console.Write("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }

            Console.Read();

        }
    }
}
