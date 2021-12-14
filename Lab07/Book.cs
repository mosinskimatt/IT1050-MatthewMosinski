using System;

namespace Lab_7_Submit
{
    class Book
    {
        private string Title;
        private string Author;
        private int Year;

        public Book( string Title, String Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }
        public void Display()
        {
            Console.WriteLine("{0} written by {1} in {2}\n", Title, Author, Year);
        }
    }
}
