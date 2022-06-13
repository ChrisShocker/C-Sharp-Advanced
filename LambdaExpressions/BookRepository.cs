using System.Collections.Generic;

namespace LambdaExpressions
{
    internal partial class Program
    {
        public class BookRepository
        {
            public List<Book> GetBooks()
            {
                //use object initializer to create the book objects
                return new List<Book>
                {
                    new Book() {Title = "C# Basics", Price = 5},
                    new Book() {Title = "C# Intermediate", Price = 8},
                    new Book() {Title = "C# Advanced", Price = 13}
                };
            }
        }
    }
}
