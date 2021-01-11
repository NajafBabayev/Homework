using System;
namespace NadjafProject1
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }

        public Book(string author, string title, int publishyear)
        {
            Author = author;
            Title = title;
            PublishYear = publishyear;
        }

        public override string ToString()
        {
            return $"Author: {Author}, Title: {Title}, Publish Year: {PublishYear}";
        }




    }
}
