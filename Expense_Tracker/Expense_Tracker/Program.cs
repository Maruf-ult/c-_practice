using System;
using System.Collections.Generic;
using System.Linq;

namespace Expense_Tracker
{
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("========== Welcome to Expense Tracker ==========");
            Console.WriteLine("1. Add expense");
            Console.WriteLine("2. Show all expenses");
            Console.WriteLine("3. Search expense by Id");
            Console.WriteLine("4. Show recent expenses");
            Console.WriteLine("5. Delete expense");
            Console.WriteLine("6. Undo deleted expense");
            Console.WriteLine("7. Show category wise report");
            Console.WriteLine("8. Show all unique tags");
            Console.WriteLine("9. Filter expenses by date range");
            Console.WriteLine("10. Exit");
            Console.Write("Choose an option: ");
        }

        public static ExpenseCategory ReadExpenseCategory()
        {
            Console.WriteLine();
            Console.WriteLine("Choose Expense Category:");
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Transport");
            Console.WriteLine("3. Education");
            Console.WriteLine("4. Shopping");
            Console.WriteLine("5. Health");
            Console.WriteLine("6. Bills");
            Console.WriteLine("7. Other");
            Console.Write("Enter category number: ");

            int categoryInput = Convert.ToInt32(Console.ReadLine());

            if (!Enum.IsDefined(typeof(ExpenseCategory), categoryInput))
            {
                throw new Exception("Invalid expense category.");
            }

            return (ExpenseCategory)categoryInput;
        }

        public static PaymentMethod ReadPaymentMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Choose Payment Method:");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Bkash");
            Console.WriteLine("3. Nagad");
            Console.WriteLine("4. Card");
            Console.WriteLine("5. Bank");
            Console.Write("Enter payment method number: ");

            int paymentInput = Convert.ToInt32(Console.ReadLine());

            if (!Enum.IsDefined(typeof(PaymentMethod), paymentInput))
            {
                throw new Exception("Invalid payment method.");
            }

            return (PaymentMethod)paymentInput;
        }

        public static List<string> ReadTags()
        {
            Console.Write("Enter tags separated by comma, example: food,daily,university: ");
            string? tagInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(tagInput))
            {
                return new List<string>();
            }

            List<string> tags = tagInput
                .Split(',')
                .Select(tag => tag.Trim())
                .Where(tag => !string.IsNullOrWhiteSpace(tag))
                .ToList();

            return tags;
        }

        static void Main(string[] args)
        {
            ExpenseManager exp = new ExpenseManager();
            bool running = true;

            while (running)
            {
                try
                {
                    ShowMenu();

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter expense name: ");
                            string? nameInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(nameInput))
                            {
                                throw new Exception("Name cannot be empty.");
                            }

                            string name = nameInput;

                            Console.Write("Enter amount: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());

                            ExpenseCategory category = ReadExpenseCategory();

                            PaymentMethod paymentMethod = ReadPaymentMethod();

                            Console.Write("Enter date, format yyyy-MM-dd, or press Enter for today: ");
                            string? dateInput = Console.ReadLine();

                            DateTime date;

                            if (string.IsNullOrWhiteSpace(dateInput))
                            {
                                date = DateTime.Now;
                            }
                            else
                            {
                                date = DateTime.Parse(dateInput);
                            }

                            Console.Write("Enter note: ");
                            string? noteInput = Console.ReadLine();
                            string note = noteInput ?? "";

                            List<string> tags = ReadTags();

                            exp.AddExpense(name, amount, category, paymentMethod, date, note, tags);

                            break;

                        case 2:
                            exp.ShowAllExpense();
                            break;

                        case 3:
                            Console.Write("Enter expense Id: ");
                            int searchId = Convert.ToInt32(Console.ReadLine());

                            exp.FindExpenseById(searchId);
                            break;

                        case 4:
                            exp.ShowRecentExpenses();
                            break;

                        case 5:
                            Console.Write("Enter expense Id to delete: ");
                            int deleteId = Convert.ToInt32(Console.ReadLine());

                            exp.DeleteExpense(deleteId);
                            break;

                        case 6:
                            exp.undoLastDelete();
                            break;

                        case 7:
                            exp.ShowCategoryWisedReport();
                            break;

                        case 8:
                            exp.ShowAllUniqueTags();
                            break;

                        case 9:
                            Console.Write("Enter start date, format yyyy-MM-dd: ");
                            DateTime startDate = DateTime.Parse(Console.ReadLine()!);

                            Console.Write("Enter end date, format yyyy-MM-dd: ");
                            DateTime endDate = DateTime.Parse(Console.ReadLine()!);

                            DateRange range = new DateRange(startDate, endDate);

                            exp.FilterByDateRange(range);
                            break;

                        case 10:
                            Console.WriteLine("Thank you for using Expense Tracker.");
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please choose between 1 and 10.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter the correct type of value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}