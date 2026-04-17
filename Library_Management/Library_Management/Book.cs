using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; private set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public void BorrowBook()
        {
            IsBorrowed = true;
            Console.WriteLine($"{Title} by {Author} borrowed successfully.");
        }

        public void ReturnBook()
        {
            IsBorrowed = false;
            Console.WriteLine($"{Title} returned successfully.");
        }
    }
}
