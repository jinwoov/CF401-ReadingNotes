using System;
using System.Collections.Generic;
using System.Text;

namespace d10class4Demo.folder
{
    class Bookstore
    {
        public Book[] books { get; set; }
        public string name { get; set; } = "Unknown Name";

        private int _initialBookSize = 10;
        public Bookstore()
        {
            books = new Book[_initialBookSize];
        }

        public Bookstore(string Name)
        {
            Name = name;
            books = new Book[_initialBookSize];
        }

        public  Book PurchaseBook(string bookName)
        {
            Book book = null;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == bookName)
                { 
                    books[i].CheckedOut = true;
                book = books[i];
                }

            }
            return book;
        }
    }
}
