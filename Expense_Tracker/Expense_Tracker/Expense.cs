using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker
{
    internal class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public ExpenseCategory Category { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public List<string> Tags { get; set; }

        public Expense(
            int id,
            string name,
            decimal amount,
            ExpenseCategory category,
            PaymentMethod paymentMethod,
            DateTime date,
            string note,
            List<string> tags)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Category = category;
            PaymentMethod = paymentMethod;
            Date = date;
            Note = note;
            Tags = tags;
        }

        public void ShowExpense()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Payment Method: {PaymentMethod}");
            Console.WriteLine($"Date: {Date:yyyy-MM-dd}");
            Console.WriteLine($"Note: {Note}");
            Console.WriteLine($"Tags: {string.Join(", ", Tags)}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
