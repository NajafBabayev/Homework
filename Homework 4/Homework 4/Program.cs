using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1)Key və value-su string tipində olan Dictionary yaradın.

            //b) İstifadəçidən 10 dəfə iki söz yazılması istənilsin:

            //b.1) Birinci söz ölkə adı. b.2) İkinci söz paytaxt adı.

            //c) Daha sonra istifadəçi ölkə adı yazaraq daxil edilən list-dən paytaxt adını almalıdır.

            //d) Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də olan bütün ölkə-paytaxlar print edilsin.

            //e) Nəticəni aldıqdan sonra yeni paytaxt axtarışı edilsin yoxsa proqram bitsin deyə istifadəçidən soruşulmalıdır və cavaba müvafiq əməliyyat baş verməlidir.

            //Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Country name: ");
            //    string countryName = Console.ReadLine();

            //    Console.WriteLine("Capital of the country: ");
            //    string capitalName = Console.ReadLine();

            //    dictionary.Add(countryName, capitalName);
            //}
            //    SEARCH:

            //    Console.WriteLine("Please, enter country name: ");
            //    string searchCountryName = Console.ReadLine();

            //    Console.WriteLine("Your result: ");
            //    Console.WriteLine(dictionary.GetValueOrDefault(searchCountryName));

            //    Console.WriteLine();
            //    Console.WriteLine("Do you want to search again? y/n");

            //    ConsoleKeyInfo pressedButton = Console.ReadKey();

            //    if (pressedButton.Key == ConsoleKey.Y)
            //    {
            //        Console.WriteLine();
            //        goto SEARCH;
            //    }



            // 3) Aşağıdaki tapşırığı yerinə yetirin:
            //a) int tipində List yaradın.

            //b) İstifadəçi 10 müxtəlif ədədlərlə listi doldursun.

            //c) Daha sonra list -in son 5 elementi ilə ilk 5 elementinin yerlərini dəyişdirin

            //List<int> numbers = new List<int>();

            //Console.WriteLine("Zehmet olmasa reqem daxil edin");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"({i + 1}/10)");
            //    numbers.Add(Int32.Parse(Console.ReadLine()));
            //}

            //numbers.Reverse(0,5) ;

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}




            //4) Aşağıdaki tapşırığı yerinə yetirin:
            //a) int tipli elə bir kolleksiya yaradın ki, içində bütün item - lər unique olsun(təkrarlanma olmasın) və sort edilmiş vəziyyətdə olsun.

            // b) Daha sonra içini müxtəlif ədədlərlə doldurun. (Console - dan)

            //c) Nəticəni ekrana çap edin.
            //SortedSet<int> Sorted = new SortedSet<int>();
            //Console.WriteLine("Zehmet olmasa reqem daxil edin");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"({i + 1}/10)");
            //    Sorted.Add(Int32.Parse(Console.ReadLine()));
            //}
            //foreach(int i in Sorted)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
