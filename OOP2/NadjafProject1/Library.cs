using System;
using System.Collections.Generic;

namespace NadjafProject1
{
    public class Library
    {
        private List<Book> books = new List<Book> ();

        


        public void AddToLibrary(Book book) {
            books.Add(book);
        }

        public void ShowAllBook() {
            foreach (Book b in books)
            {
                Console.WriteLine(b);
            }
        }

       

        
    }
}
