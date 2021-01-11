using System;
namespace NadjafProject1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Book MyFavoriteBook {  get; private set; }


        public Person(string name, string surname, int age)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
        }


        public void AddfavoriteBook(Book b1) {
            Helper.TextAndColor(ConsoleColor.Red, $"Your favorite book:");
            MyFavoriteBook = b1;
        }

        public void Info() {
            Helper.TextAndColor(ConsoleColor.DarkGreen, $"My name is {FirstName} {LastName} and i am {Age} yeasr old. My favorite book is {MyFavoriteBook}");
            
        }

    }
}
