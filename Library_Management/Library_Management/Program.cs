namespace Library_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool process = true;

            while (process)
            {
                Console.WriteLine("\n--- Library Management System ---");
                Console.WriteLine("1: Add user");
                Console.WriteLine("2: Add book");
                Console.WriteLine("3: Show all books");
                Console.WriteLine("4: Borrow book");
                Console.WriteLine("5: Return book");
                Console.WriteLine("6: Show borrowed books");
                Console.WriteLine("7: Exit");
                Console.Write("Choose option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter member id: ");
                        int memberId = int.Parse(Console.ReadLine());

                        Console.Write("Enter member name: ");
                        string memberName = Console.ReadLine();

                        Console.Write("Enter role (student/teacher): ");
                        string role = Console.ReadLine();

                        library.RegisterMember(memberId, memberName, role);
                        break;

                    case 2:
                        Console.Write("Enter book id: ");
                        int bookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter author name: ");
                        string author = Console.ReadLine();

                        library.AddBook(bookId, title, author);
                        break;

                    case 3:
                        library.ShowAllBooks();
                        break;

                    case 4:
                        Console.Write("Enter book id: ");
                        int borrowBookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter member id: ");
                        int borrowMemberId = int.Parse(Console.ReadLine());

                        library.BorrowBook(borrowBookId, borrowMemberId);
                        break;

                    case 5:
                        Console.Write("Enter book id: ");
                        int returnBookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter member id: ");
                        int returnMemberId = int.Parse(Console.ReadLine());

                        library.ReturnBook(returnBookId, returnMemberId);
                        break;

                    case 6:
                        library.ShowBorrowedBooks();
                        break;

                    case 7:
                        process = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
