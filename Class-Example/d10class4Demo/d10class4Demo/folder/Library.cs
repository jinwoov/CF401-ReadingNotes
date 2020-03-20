using System;
using System.Collections.Generic;
using System.Text;

namespace d10class4Demo.Libary
{
    class Library
    {
        //property is declared like a field but it has what we call getters and setters
        // get a value and set a value
        // after c#6.0 auto impleented 

        public string Address { get; set; }

        private string name; // the filed also called backing store

        // to set restriction 
        // this is the manual way of creating properties.

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int month;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if((value > 0 ) && (value < 13))
                {
                    month = value;
                }
            }
        }

        // dont manipulate data // bad practice 
        private int number;
        public int Number
        {
            get
            {
                return number++;

            }
        }

        public Library(string name)
        {

        }
        // class is going to contain methods, behaviors and properties that define this class
        /// <summary>
        /// Thisis a method that is called library
        /// </summary>
        /// <param name="word">The word is phrase or saying</param>
        public void MyLibrary(string word)
        {
            Console.WriteLine($"This is the word {word}");
        }
    }
}
