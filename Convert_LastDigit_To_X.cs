//10 Write a Program which accepts mobile no as a string from the user and converts the last 5 digits into X.
//INPUT : 1234567890
//OUTPUT: 12345XXXXX

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Convert_LastDigit_To_X
    {
        public static void Convert_Last()
        {
            string str;
            Console.WriteLine("Enter mobile number : ");
            str = Console.ReadLine();
            int n = str.Length;

            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    Console.Write(str[i]);
                }
                else
                {
                    Console.Write("X");
                }

            }
        }
    }
}











