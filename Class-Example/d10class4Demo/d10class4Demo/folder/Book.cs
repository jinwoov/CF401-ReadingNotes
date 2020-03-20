using System;
using System.Collections.Generic;
using System.Text;

namespace d10class4Demo.folder
{
    class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }
        public bool IsSigned { get; set; }
        public bool CheckedOut { get; set; }

        public Author Author { get; set; }
        // backing store
        // doing this instead of private
        public Book(string title, string publisher, int numberOfPages)
        {
            Title = title;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
            // bools defaults to the false
        }
    }
}
