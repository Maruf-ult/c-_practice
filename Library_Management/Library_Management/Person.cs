using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public virtual int GetBorrowedLimit()
        {
            return 2;
        }
    }
}