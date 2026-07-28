//Write a Program which accepts no from the user and print the same in words.
//INPUT : 98732
//OUTPUT: Nine Eight Seven Three Two

using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Convert_Number_To_World
    {
        public static void convert_to_word()
        {
            string num;

            Console.Write("INPUT : ");
            num = Console.ReadLine();

            Console.Write("OUTPUT : ");

            foreach (char ch in num)
            {
                switch (ch)
                {
                    case '0':
                        Console.Write("Zero ");
                        break;
                    case '1':
                        Console.Write("One ");
                        break;
                    case '2':
                        Console.Write("Two ");
                        break;
                    case '3':
                        Console.Write("Three ");
                        break;
                    case '4':
                        Console.Write("Four ");
                        break;
                    case '5':
                        Console.Write("Five ");
                        break;
                    case '6':
                        Console.Write("Six ");
                        break;
                    case '7':
                        Console.Write("Seven ");
                        break;
                    case '8':
                        Console.Write("Eight ");
                        break;
                    case '9':
                        Console.Write("Nine ");
                        break;
                    default:
                        Console.Write("Invalid ");
                        break;
                }
            }

            Console.Read();
        }
    }
}
