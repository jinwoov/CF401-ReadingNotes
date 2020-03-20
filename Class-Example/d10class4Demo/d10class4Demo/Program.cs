using System;
using d10class4Demo.Libary;
using d10class4Demo.folder;


namespace d10class4Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            LibaryExample();

            Example2();
        }

        static void Example2()
        {
            Book book = new Book("harry porter", "", 343);
            book.Author = new Author("jk", "rolling");
            book.Author.SignedBook(book);

            Author drSuess = new Author("Dr", "Seuess");
            Book newBook = new Book("The Cat in the Hat", " some ", 32);
            drSuess.SignedBook(newBook);
            newBook.Author = drSuess;
        }

        static void LibaryExample()
        {
            // instantiate an object
            // is by using the "new"
            // {data type} {variable name} = value
            string name = "Josie";

            Library libary = new Library("Jin");

            // this force set and getter
            libary.MyLibrary($"my name is {libary.Name}");

            // force a setter
            libary.Name = "Josie is super duper";


        }
    }
}
