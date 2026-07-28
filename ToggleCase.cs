// Write a Program to convert given name in toggle case.
//INPUT : JoHn F kEnNedy
//OUTPUT: jOhN f KeNneDY 

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class ToggleCase
    {
        public static void togglecase()
        {
            string str;
            Console.WriteLine("Enter a string for toggle case : ");
            str = Console.ReadLine();

            string result = "";
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);

                }
                else
                {
                    result += char.ToUpper(ch);
                }
            }
            Console.WriteLine(result);

        }
    }
}
