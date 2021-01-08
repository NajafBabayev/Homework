using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // aşağıdaki məsələni həll edin:
            //a) birölçülü 10 elementdən ibarət integer massivi yaradın.

            //b) istifadəçilərdən onu mənfi və müsbət ədədlərlə doldurmaq istənilsin.

            //c) daha sonra mənfi və müsbət ədədlərin sayı console-a print edilsin.

            //misal üçün:

            //[1, -2, 0, 10, -4]

            //burada iki mənfi(-2 və - 4) və 3 müsbət ədəd var(1, 0, 10).ekranda bunu görməliyik:

            //mənfi: 2

            //müsbət: 3

            //1ci kod
            //int[] mas = new int[10];
            //int i = 0;
            //string test;
            //int plus = 0;
            //int minus = 0;
            //Console.WriteLine("Massivi musbet ve menfi ededler ile doldurun. Inputu bitirdikde 'stop' yazin:");
            //do
            //{
            //    test = Console.ReadLine();
            //    if (test == "stop") break;
            //    mas[i] = Convert.ToInt32(test);
            //    ++i;
            //}
            //while (true);

            //foreach (int j in mas)
            //{
            //    if (j > 0)
            //    {
            //        ++plus;
            //        continue;
            //    }

            //    else if (j < 0)
            //    {
            //        ++minus;
            //        break;
            //    }
            //}
            //Console.WriteLine($"Menfi:{minus}\nMusbet:{plus}");

            // Aşağıdaki məsələni həll edin:
            //a) Birölçülü 10 elementdən ibarət integer massivi yaradın.

            //b) İstifadəçilərdən onu ədədlərlə doldurmaq istənilsin.

            //c) Daha sonra rəqəmlər sort edilsin və tərsinə olaraq ekrana çap edilsin.

            //Ikinci code
            //int[] mas = new int[10];
            //int i = 0;
            //string test;
            //int count = 0;

            //Console.WriteLine("Massivi ededler ile doldurun. Inputu bitirdikde 'stop' yazin:");
            //do
            //{
            //    test = Console.ReadLine();
            //    if (test == "stop") break;
            //    mas[i] = Convert.ToInt32(test);
            //    ++i;++count;
            //}
            //while (true);
            //int j = 0;
            //j = mas.Length - 1;
            //for (j = mas.Length - 1; j >= 0; j--)
            //{   
            //    Console.Write(mas[j] + ", ");

            //}

            // Aşağıdaki məsələni həll edin:
            //a) Birölçülü string massivi yaradın.

            //b) İstifadəçidən sözlər yazılması istənilsin və bu sözlərlə massiv doldurulsun.

            //c) Tərkibində "a" hərfi olan sözlərin hamsını böyük hərflərlə, "o" hərfi olan isə balaca hərflərlə ekrana çap edin.

            //d) Əgər həm "a", həm də "o" hərfləri varsa, o zaman ilk hansı hərf gəlirsə o üstün tutulsun. "a" gəlirsə hərflər böyüsün, "o" gəlirsə balacalaşsın.

            //3cu code:
            //string[] mas = new string[10];
            
                     

            //Console.WriteLine("Massivi sozler ile doldurun. inputu bitirdikde 'stop' yazin:");
            //for (int i= 0;i< mas.Length;++i)
            //{
            //    mas[i] = Console.ReadLine();
            //}


            //foreach (string word in mas)
            //{
            //    if (word.Contains("a") && word.Contains("o"))
            //    {
            //        int indexa = word.IndexOf("a");
            //        int indexo = word.IndexOf("o");
            //        if (indexa > indexo)
            //        {
            //            Console.WriteLine(word.ToLower());
            //        } 
            //        else
            //        {
            //            Console.WriteLine(word.ToUpper());
            //        }

            //    } 
            //    else if (word.Contains("o"))
            //    {
            //        Console.WriteLine(word.ToLower());
            //    }
            //    else if (word.Contains("a"))
            //    {
            //        Console.WriteLine(word.ToUpper());
            //    }
            //    else
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
        }
    }
}
