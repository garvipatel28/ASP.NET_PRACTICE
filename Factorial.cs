using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET_PRACTICE
{
    internal class Factorial
    {
        public static void fact()
        {

            int n, fact = 1;

            Console.WriteLine("Enter Number : ");

            string str = Console.ReadLine();

            n = Convert.ToInt32(str);

            for (int i = 1; i <= n; i++)

            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial : {0}", fact);

            Console.Read();
        }
    }
}
