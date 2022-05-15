using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    internal class Book
    {
        public int BookId { get; set; }
        private string BookName { get; set; }
        private decimal? BookPrice { get; set; }
        private int NumberOfBooks { get; set; }

        // Default Constructor 
        public Book()
        {

        }

        // Parameterized Constructor
        public Book(int BookId, string BookName, decimal BookPrice, int NumberOfBooks)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.BookPrice = BookPrice;
            this.NumberOfBooks = NumberOfBooks;
        }

        // Copy Constructor
        public Book(Book book)
        {
            this.BookId = book.BookId;  
            this.BookName = book.BookName;
            this.BookPrice = book.BookPrice;
            this.NumberOfBooks = book.NumberOfBooks;
        }

        // Private Constructor
        //private Book()
        //{
        //    this.BookId = 0;
        //}

        // Static Constructor
        static Book()
        {
            Console.WriteLine("Static Constructor called");
        }

        public void setBookName(string BookName)
        {
            this.BookName = BookName;
        }
        public string getBookName()
        {
            return this.BookName;
        }

        public void setBookPrice(decimal? BookPrice)
        {
            this.BookPrice = BookPrice;
        }
        public decimal? getBookPrice()
        {
            return this.BookPrice;
        } 

        public void setNumberOfBooks(int NumberOfBooks)
        {
            this.NumberOfBooks = NumberOfBooks;
        }
        public int getNumberOfBooks()
        {
            return this.NumberOfBooks;
        }
    }
}
