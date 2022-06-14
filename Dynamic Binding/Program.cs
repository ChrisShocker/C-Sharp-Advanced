using System;

namespace Dynamic_Binding
{
    /*
     *  Dynamic Binding
     *  - Allows binding at runtime instead of compile time
     *  - Skips compile time checks
     *   
     *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Declare an item to be dynamic
             * - we can also set the value anytime without error
             */
            dynamic someObject = "something";
            Console.WriteLine(someObject);

            someObject = 4;
            Console.WriteLine(someObject);

            /* Since the item is dynamic we can call functions that don't currenlty exist 
             * - The application will still crash if the declared function isn't found at runtime
             */

            Console.WriteLine("I'm gonna crash because a function wasn't found at runtime...");
            System.Threading.Thread.Sleep(2000);
            
            someObject.RunTimeFunc();
        }
    }
}
