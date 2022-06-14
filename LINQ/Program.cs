using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Without LINQ
            Console.WriteLine("Example 1: Without LINQ");
            Console.WriteLine("Books under $5:");    
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 5)
                {
                    Console.WriteLine(book.Title);
                    cheapBooks.Add(book);
                }
            }

            //LINQ
            Console.WriteLine("\nExample 1: With LINQ");
            Console.WriteLine("Books under $5:");    
            var cheapBooksLINQ = books.Where(Book => Book.Price < 5);
            //Note: We can use anon functions easily with LINQ extension methods
            foreach (var book in cheapBooksLINQ)
            {
                Console.WriteLine(book.Title);
            }
        }
    }


    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book 1", Price = 2},
                new Book() {Title = "Book 2", Price = 3},
                new Book() {Title = "Book 3", Price = 4},
                new Book() {Title = "Book 4", Price = 5},
                new Book() {Title = "Book 5", Price = 6},
            };
        }
    }
}
