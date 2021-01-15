using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        delegate void Print(string a);
        //2 ci tapshiriq
        //public delegate bool FilterString(string word);
        static void Main(string[] args)
        {
            Print print;
            Dictionary<string, string> Months = new Dictionary<string, string>
            {
                ["January"] = "Yanvar",
                ["February"] = "Fevral",
                ["March"] = "Mart",
                ["April"] = "Aprel",
                ["May"] = "May",
                ["June"] = "Iyun",
                ["July"] = "Iyul",
                ["August"] = "Avgust",
                ["September"] = "Sentabr",
                ["October"] = "Oktyabr",
                ["November"] = "Noyabr",
                ["December"] = "Dekabr"
            };
            Console.WriteLine("Chose a month please by typing number from 1 to 12:");
            int i = Convert.ToInt32(Console.ReadLine());
            string selection1 = Months.ElementAt(i-1).Key;
            
            Console.WriteLine("What do you want to do?\n1)Translate month\n2)Print Season name");
            string selection2 = Console.ReadLine();
            switch (selection2)
            {
                case "1":
                    print=TranslateMonthName;
                    print(Months.ElementAt(i-1).Value);
                    
                    break;
                case "2":
                    print=PrintSeasoneName;
                    if (0 <= i && i < 3)
                    {
                        print("Winter");
                    }
                    else if (3 <= i && i < 6)
                    {
                        print("Spring");
                    }
                    else if (6 <= i && i < 9)
                    {
                        print("Summer");
                    }
                    else if (9 <= i && i < 11)
                    {
                        print("Fall");
                    }
                    else if (12 == i)
                    {
                        print("Winter");
                    }
                    break;
                    
            }
            //2
            //List<string> list = new List<string>();
            //list.Add("Fikret");
            //list.Add("Nadjaf");
            //list.Add("Murikd");
            //list.Add("BurmNotAcceptedn");


            //List<string> newArr1 = ParseWordList(list, word => word.Contains("i"));
            //List<string> newArr2 = ParseWordList(list, word => word.Length < 7);
            //List<string> newArr3 = ParseWordList(list, word => !word.Contains("B"));
            //List<string> newArr4 = ParseWordList(list, word => !word.Contains("u"));
            //List<string> newArr5 = ParseWordList(list, word => !word.Contains("o"));
            //foreach (string item in newArr1)
            //{
            //    Console.WriteLine(item);
            //}
        }
       
        private static void TranslateMonthName(string tmonth)
        {
             Console.WriteLine($"{tmonth}"); 
        }
        private static void PrintSeasoneName(string season)
        {
           
            Console.WriteLine($"{season}");
        }
       //3 cu tapshirigi dersde yazmishdiq

    }
}
