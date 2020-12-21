using System;

namespace HM2
{
    class Program
    {
        static void Main(string[] args)
        {
        FirstCase:
            Console.WriteLine("Please type a word in English.It should contain  5 letters,at least one 'B' letter and dot(.) in the end. Also, please avoid using letter 'a':");
            string a = Console.ReadLine();
            if (a.Length != 6)
            {
                goto FirstCase;
            }

            if (a.ToLower().Contains('b') || a.ToUpper().Contains('B'))
            {
                goto SecondCase;
            }
            else
            {
                goto FirstCase;
            }
        SecondCase:
            if (a.Contains('a') || a.Contains('A'))
            {
                goto FirstCase;
            }
            if (a.Contains('.'))
            {
                goto ThirdCase;
            }

            else
            {
                goto FirstCase;
            }
        ThirdCase:
            char o = 'o';
            if (a.Contains(o))
            {
                int indexchar = a.IndexOf(o);
                char upperO = Char.ToUpper(a[indexchar]);
                a = a.Replace(o, upperO);
            }
            char L = 'L';
            if (a.Contains(L))
            {
                int indexcharl = a.IndexOf(L);
                char lowerL = Char.ToLower(a[indexcharl]);
                a = a.Replace(L, lowerL);
            }

            foreach (char letter in a)
            {

                a = a.Replace("u", "k");
                a = a.Replace("z", "");



            }

            Console.WriteLine(a);
            int dot = a.Length - 1;
            a = a.Remove(dot);
            string ReverseA1 = a.Substring(0, 2);
            string ReverseA2 = a.Substring(2, a.Length - 2);
            string ReverseA = ReverseA2 + ReverseA1;
            Console.WriteLine(ReverseA);
        }

    }
}
