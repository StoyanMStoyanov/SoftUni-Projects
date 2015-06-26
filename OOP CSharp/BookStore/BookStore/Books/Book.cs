using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Books
{
    public class Book:IBook
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("title", "Book title cannot be null, empty or whitespace.");
                this.title = value;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("author", "Author cannot be null, empty or whitespace.");
                this.author = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentNullException("price", "Price cannot be negative.");
                this.price = value;
            }
        }
    }
}
