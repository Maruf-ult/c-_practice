using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker
{
    internal class ExpenseManager
    {
        private List<Expense> expenses = new List<Expense>();
        private HashSet<string> uniqueTags = new HashSet<string>();
        private Stack<Expense> deletedExpenses = new Stack<Expense>();
        private Queue<Expense> recentExpenses = new Queue<Expense>();
        private Dictionary<int, Expense> expenseById = new Dictionary<int, Expense>();

        private int nextId = 1;

        public void AddExpense(string name,decimal amount,ExpenseCategory category ,PaymentMethod payment,DateTime date,String note,List<string> tags)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("name can not be empty");
            }
            if(amount <= 0)
            {
                throw new Exception("Amount must be greater than zero");
            }

            Expense expense = new Expense(
                nextId,
                name,
                amount,
                category,
                payment,
                date,
                note,
                tags
                );

            expenses.Add(expense);
            expenseById.Add(nextId, expense);

            foreach (string tag in tags)
            {
                uniqueTags.Add(tag.ToLower());
            }

            recentExpenses.Enqueue(expense);


            if (recentExpenses.Count > 5)
            {
                recentExpenses.Dequeue();
            }


            nextId++;

            Console.WriteLine("Expenses added successfully");

        }

        public void DeleteExpense(int id)
        {
            if(!expenseById.TryGetValue(id,out Expense? expense))
            {
                throw new Exception("Expense not found");
            }
            expenses.Remove(expense);
            expenseById.Remove(id);
            deletedExpenses.Push(expense);

            Console.WriteLine("Expense deleted successfully");
            
        }

        public void undoLastDelete()
        {
            if(deletedExpenses.Count == 0)
            {
                throw new Exception("No deleted expenses stored");
            }

            Expense restoredExpense = deletedExpenses.Pop();
            expenses.Add(restoredExpense);
            expenseById.Add(restoredExpense.Id, restoredExpense);

            Console.WriteLine("Expense restored successfully");

        }

        public void ShowCategoryWisedReport()
        {
            if(expenses.Count == 0)
            {
                throw new Exception("no expenses found");
            }
            Dictionary<ExpenseCategory, decimal> categoryTotals = new Dictionary<ExpenseCategory, decimal>();
            
            foreach(Expense expense in expenses)
            {
                if (categoryTotals.ContainsKey(expense.Category))
                {
                    categoryTotals[expense.Category] += expense.Amount;
                }
                else
                {
                    categoryTotals.Add(expense.Category, expense.Amount);
                }
            }

            Console.WriteLine("-----------Category wised report--------");
            foreach(var item in categoryTotals)
            {
                Console.WriteLine($"category: {item.Key} Amount: {item.Value}  ");
            }
        }

        public void ShowAllUniqueTags()
        {
            if(uniqueTags.Count == 0)
            {
                throw new Exception("Unique tags not found");
            }
            Console.WriteLine("----------- Unique Tags --------");

            foreach (var item in uniqueTags)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowRecentExpenses()
        {
            if(recentExpenses.Count == 0)
            {
                throw new Exception("recentExpenses not found");
            }

            Console.WriteLine("----------- Unique Tags --------");
            foreach(Expense expense in recentExpenses)
            {
                expense.ShowExpense();
            }

        }

        public void FindExpenseById(int id)
        {
            if(!expenseById.TryGetValue(id,out Expense? expense))
            {
                throw new Exception("Expense not found");
            }
            Console.WriteLine("----------- Expenese --------");
            Console.WriteLine(expenseById[id]);
            expense.ShowExpense();
        }

        public void ShowAllExpense()
        {
            if (expenses.Count == 0)
            {
                throw new Exception("Expenses not found");
            }


            foreach (Expense expense in expenses)
            {
                expense.ShowExpense();
            }
        }

        public void FilterByDateRange(DateRange range)
        {
            bool found = false;

            foreach (Expense expense in expenses)
            {
                if (range.Contains(expense.Date))
                {
                    expense.ShowExpense();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No expenses found in this date range.");
            }
        }

    }
}
