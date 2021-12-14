using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Submit
{
    class BookTest
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Percy Jackson and The Olympians: The Lightning Thief",
                "Rick Riordan", 2005);

            myBook.Display();
        }
    }
}
