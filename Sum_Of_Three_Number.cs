using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Sum_Of_Three_Number
    {
        public static void SumOfThree()
        {
            int a, b, c, result;
            string str;

            Console.Write("Enter Number 1 : ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2 : ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3 : ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            result = Sum(a, b, c);

            Console.WriteLine("Sum : " + result);

            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;

        }
    }
}
