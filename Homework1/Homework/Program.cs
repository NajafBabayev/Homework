using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
        FirstCase:
            Console.WriteLine("3 reqemli ededi daxil edin");

            string a = Console.ReadLine();

            if (a.Length != 3)
            {

                Console.WriteLine("Sehv eded daxil edilib. Eded 3 reqemli olmalidir.Zehmet olmasa bir daha 3 reqemli ededi daxil edin");
                goto FirstCase;

            }
        SecondCase:
            Console.WriteLine("5 reqemli ededi daxil edin");

            string b = Console.ReadLine();

            if (b.Length != 5)
            {

                Console.WriteLine("Sehv eded daxil edilib. Eded 5 reqemli olmalidir.Zehmet olmasa bir daha 3 reqemli ededi daxil edin");
                goto SecondCase;
            }
            string c = a.Substring(0, 2) + b.Substring(1);
            Console.WriteLine(c);
            int c1 = Int32.Parse(c.Substring(0, 3));
            Console.WriteLine(c1);
            int c2 = Int32.Parse(c.Substring(3));
            Console.WriteLine(c2);
            int calculate = c1 - c2;

            Console.WriteLine(calculate.ToString());

        }
    }
}