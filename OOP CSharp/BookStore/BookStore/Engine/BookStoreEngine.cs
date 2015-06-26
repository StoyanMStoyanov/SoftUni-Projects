using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Books;
using BookStore.Interfaces;

namespace BookStore.Engine
{
    class BookStoreEngine
    {
        private readonly List<Book> books;
        private decimal revenue;
        private readonly IRenderer renderer;
        private readonly IInputHandler inputHandler;

        public BookStoreEngine(IRenderer renderer, IInputHandler inputHandler)
        {
            this.renderer = renderer;
            this.inputHandler = inputHandler;
            this.books = new List<Book>();
            this.revenue = 0;
            this.IsRunning = true;
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            while (this.IsRunning)
            {
                string command = this.inputHandler.ReadLine();
                if (string.IsNullOrWhiteSpace(command)) continue;
                string[] commandArgs = command.Split();
                string commandResult = this.ExecuteCommands(commandArgs);
                this.renderer.WriteLine(commandResult);
            }
            this.renderer.WriteLine("Total revenue: {0:F2}", this.revenue.ToString());
        }

        private string ExecuteCommands(string[] commandArgs)
        {
            switch (commandArgs[0])
            {
                case "add":
                    return this.ExecuteAddBookCommand(commandArgs);
                case "sell":
                    return this.ExecuteShellBookCommand(commandArgs);
                case "remove":
                    return this.ExecuteRemoveBookCommand(commandArgs);
                case "stop":
                    this.IsRunning = false;
                    return "Good Bye.";
                default:
                    return "Uncnovn command.";
            }
        }

        private string ExecuteRemoveBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];

            Book bookToRemove = this.books.FirstOrDefault(b => b.Title ==title);
            if (bookToRemove == null)
                return "Book does not exist.";
            this.books.Remove(bookToRemove);
            return "Book removed.";
        }

        private string ExecuteShellBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];
            IBook bookToShell = this.books.FirstOrDefault(b => b.Title == title);
            if (bookToShell == null)
                return "Book does not exist.";
            if (commandArgs[0] == "sell")
                this.revenue += bookToShell.Price;
            return "Book sold.";
        }

        private string ExecuteAddBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];
            string author = commandArgs[2];
            decimal price = decimal.Parse(commandArgs[3]);

            this.books.Add(new Book(title, author, price));

            return "Book added.";
        }

    }
}
