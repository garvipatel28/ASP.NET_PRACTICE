//Write a program to convert given name in upper characters.
//INPUT: John F Kennedy
//OUTPUT: JOHN F KENNEDY 

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class UpperCase
    {
        public static void uppercase()
        {
            string str, result;
            Console.WriteLine("Enter a string : ");
            str = Console.ReadLine();

            result = str.ToUpper();
            Console.WriteLine(result);

        }
    }
}
