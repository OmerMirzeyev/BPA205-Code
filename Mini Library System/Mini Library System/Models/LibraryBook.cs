using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Library_System.Models
{
    public class LibraryBook : IBorrowable
    {
        private bool IsBorrowed;
        public Book BookInfo { get; init; }
        public LibraryBook(Book book)
        {
            BookInfo = book;
            IsBorrowed = false;
        }
        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("Already borrowed");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"'{BookInfo.Title}' successfully retrieved.");
            }
        }

        public void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine("Not borrowed");
            }
            else
            {
                IsBorrowed = false;
                Console.WriteLine($"'{BookInfo.Title}' returned successfully.");
            }
        }
    }
}
