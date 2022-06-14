using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    /*
     * LINQ
     * - Used to query or transform any data that's LINQ enabled
     * - Always working with objects
     * - Strongly Typed
     * - Provides a consistent model for querying different databases ie SQL, XML, .Net etc.
     * 
     * 
     * Intro to LINQ:
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
     * Overview of LINQ:
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            /****************************************************************************/
            //Example 1: Create new list with books < $5
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

            //Example 1: Create new list with books < $5
            //LINQ
            Console.WriteLine("\nExample 1: With LINQ");
            Console.WriteLine("Books under $5:");

            var cheapBooksLINQ = books
                .Where(Book => Book.Price < 5);

            //Note: We can use anon functions easily with LINQ extension methods
            foreach (var book in cheapBooksLINQ)
            {
                Console.WriteLine(book.Title);
            }
            /****************************************************************************/

            //Example 2: LINQ Sort collection 
            Console.WriteLine("\nExample 2: With LINQ");
            Console.WriteLine("Order by book price");
            var sortedBooks = new List<Book>();

            sortedBooks = books
                .OrderBy(book => book.Price)
                .ToList();

            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book.Title + "   " + "$" + book.Price);
            }
            /****************************************************************************/

            //Example 3: LINQ Chaining
            Console.WriteLine("\nExample 3: LINQ Chaining");
            Console.WriteLine("Find books < $5 then order by book price");

            var cheapBooksChain = books
                .Where(Book => Book.Price < 5)
                .OrderBy(book => book.Price);

            foreach (var book in cheapBooksChain)
            {
                Console.WriteLine(book.Title + "   " + "$" + book.Price);
            }
            /****************************************************************************/

            /*
             * Example 4: LINQ Select
             * - Convert an existing item to a new object
             */
            Console.WriteLine("\nExample 4: LINQ Select");
            Console.WriteLine("Find Books < $5 and only select their title, ie create list with only book titles");

            var cheapBooksSelect = books
                .Where(Book => Book.Price < 5)
                .Select(book => book.Title);

            foreach (var book in cheapBooksSelect)
            {
                Console.WriteLine(book);
            }
            /****************************************************************************/

            /*
             * Example 5: LINQ Query Operator with chaining 
             * - The query operator uses the same LINK extension methods, just shorter syntax
             */

            Console.WriteLine("\nExample 5: LINQ Query Operator");
            Console.WriteLine("Find Books < $5, sort by price, and return all book objects");

            var cheapBooksQueryOp = from book in books
                                    where book.Price < 5
                                    orderby book.Price
                                    select book;

            foreach (var book in cheapBooksQueryOp)
            {
                Console.WriteLine(book.Title + "   " + "$" + book.Price);
            }
            /****************************************************************************/


            /*
             * Example 6: LINQ Single 
             * returns only 1 object based on the predicate
             */

            Console.WriteLine("\nExample 6: LINQ Single");
            Console.WriteLine("Go through list of books and return specific book with title 'Book 1'");

            var singleBook = books
                .Single(book => book.Title == "Book 1");

                Console.WriteLine(singleBook.Title + "   " + "$" + singleBook.Price);

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
                new Book() {Title = "Book 1", Price = 8},
                new Book() {Title = "Book 2", Price = 4},
                new Book() {Title = "Book 3", Price = 9},
                new Book() {Title = "Book 4", Price = 10},
                new Book() {Title = "Book 5", Price = 1},
            };
        }
    }
}
