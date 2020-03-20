using System;
using System.Collections.Generic;
using System.Text;

namespace d10class4Demo.folder
{
    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void SignedBook(Book book)
        {
            book.IsSigned = true;
        }
    }
}
