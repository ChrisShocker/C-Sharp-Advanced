using System;

namespace Delegates
{
    /*
     * Deletgates are types that reference methods
     * used to pass methods to as arguments to other methods
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
     */

    internal partial class Program
    {

        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            //Create instance of delegate, and assign it to a function
            PhotoProcessor.PhotoFilterhandler filterHandler = filters.ApplyContrast;

            //additional function pointers can be applied to the delegate instance
            filterHandler += filters.ApplyBrightness;
            filterHandler += filters.Resize;

            //we can call custom functions/filters we've created
            filterHandler += AddAnimation;

            //pass in the custom delegate we created
            processor.Process("path", filterHandler);
        }

        //we can also create our own filters and pass them to the filterHandler as long as they follow the same delegate signature
        static void AddAnimation(Photo photo)
        {
            Console.WriteLine("Animation Added");
        }
    }
}
