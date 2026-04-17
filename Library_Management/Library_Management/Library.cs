using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal class Library
    {
        private List<Book> AllBooks = new List<Book>();
        private List<Person> Members = new List<Person>();

        public void AddBook(int id, string title, string author)
        {
            Book existingBook = AllBooks.FirstOrDefault(b => b.Id == id);
            if (existingBook != null)
            {
                Console.WriteLine("Book ID already exists.");
                return;
            }

            AllBooks.Add(new Book(id, title, author));
            Console.WriteLine("Book added successfully.");
        }

        public void RegisterMember(int id, string name, string role)
        {
            Person existingMember = Members.FirstOrDefault(m => m.Id == id);
            if (existingMember != null)
            {
                Console.WriteLine("Member ID already exists.");
                return;
            }

            role = role.ToLower();

            if (role == "student")
            {
                Members.Add(new Student(id, name));
            }
            else if (role == "teacher")
            {
                Members.Add(new Teacher(id, name));
            }
            else
            {
                Console.WriteLine("Invalid role. Use student or teacher.");
                return;
            }

            Console.WriteLine("Member added successfully.");
        }

        public void BorrowBook(int bookId, int personId)
        {
            Book book = AllBooks.FirstOrDefault(b => b.Id == bookId);
            Person user = Members.FirstOrDefault(m => m.Id == personId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            if (book.IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed.");
                return;
            }

            if (user.BorrowedBooks.Count >= user.GetBorrowedLimit())
            {
                Console.WriteLine("Your borrow limit is over.");
                return;
            }

            book.BorrowBook();
            user.BorrowedBooks.Add(book);
            Console.WriteLine("Book borrowed successfully.");
        }

        public void ReturnBook(int bookId, int personId)
        {
            Book book = AllBooks.FirstOrDefault(b => b.Id == bookId);
            Person user = Members.FirstOrDefault(m => m.Id == personId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            if (!book.IsBorrowed)
            {
                Console.WriteLine("This book is not borrowed.");
                return;
            }

            if (!user.BorrowedBooks.Contains(book))
            {
                Console.WriteLine("This user did not borrow this book.");
                return;
            }

            book.ReturnBook();
            user.BorrowedBooks.Remove(book);
            Console.WriteLine("Book returned successfully.");
        }

        public void ShowAllBooks()
        {
            if (AllBooks.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("List of all books:");
            foreach (var book in AllBooks)
            {
                string status = book.IsBorrowed ? "Borrowed" : "Available";
                Console.WriteLine($"{book.Id} - {book.Title} - {book.Author} - {status}");
            }
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine("List of borrowed books:");
            foreach (var book in AllBooks)
            {
                if (book.IsBorrowed)
                {
                    Console.WriteLine($"{book.Id} - {book.Title} - {book.Author}");
                }
            }
        }
    }
}
