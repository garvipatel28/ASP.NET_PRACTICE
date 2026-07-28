//Reverse a String 

//Algorithm 

//1. Take input from user.
//2.one empty string variable (rev) to store the reversed string.
//3.loop through the string from last index to first. 
//4.rev = rev + str[i]
//5. print the rev string.

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Reverse_String
    {
        public static void reverse_str()
        {
            Console.WriteLine("Enter a String value :");
            string str = Console.ReadLine();

            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            //foreach (char c in str)
            //{
            //    rev = c + rev;
            //}

            Console.WriteLine("Reverse String : " + rev);
        }
    }
}
