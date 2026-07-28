using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Palindrome_String
    {
        public static void palindrome()
        {
            Console.WriteLine("Enter a String value :");
            string str = Console.ReadLine();

            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            if (str == rev)
            {
                Console.WriteLine("String is Pallendrome");
            }
            else
            {
                Console.WriteLine("String is not pallendrome.");
            }

        }
    }
}
