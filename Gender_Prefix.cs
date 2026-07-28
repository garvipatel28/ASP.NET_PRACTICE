//Write a Program which accepts name and gender from the user. Here, gender may have only 1 character, M or F.
//Based on the gender prefix the name Mr. & Ms.
//NAME : Hillary Clinton
//GENDER : F

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Gender_Prefix
    {
        public static void gender()
        {
            string name;
            char gender;

            Console.Write("NAME : ");
            name = Console.ReadLine();

            Console.Write("GENDER (M/F) : ");
            gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender!");
            }

            Console.Read();
        }
    }
}
