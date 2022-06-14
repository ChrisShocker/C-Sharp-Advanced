using System;
using System.Linq;

namespace Extension_Methods
{
    /*
     * Extension Methods
     *  - Allow existing classes to be extended with methods without recompiling them
     *  - Prevent changing an existing classes source code
     *  - Prevent having to create a derived type
     *  
     *  - Extension methods can only be applied to classes in the same namespace scope
     *  - Exension methods are always static
     *  - Extension methods are 2nd priority to instance methods
     *      - If a method is released in the class you're extending with the same method signature, 
     *        that method will be used instead of yours.
     *  - Use extension methods only when neccesary
     *  
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "Some really long string that should be shortened at some point...";

            //Note: String is a sealed class, so we can't inherit anything from it
            //In these cases we can use an extension method


            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }
    }

    /*
     * Use a class to create extension methods to extend the uninheritable class.
     * - These classes are always static
     * - Name it the class your extending followed by "Extensions"
     */
    public static class StringExtensions
    {
        /*
         * Methods are always static
         * 1st arg is always "this" then the type we're extending and a name
         */
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords == 0)
                return str;

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
