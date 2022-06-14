using System;

namespace Exception_Handling
{
    /*
     * Exception Handling
     * - Catch exceptions durring runtime to prevent crashing
     * - Defensive programming technique to provide more robust applications 
     *
     * https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var sum = 1;


            try
            {
                //will throw an exception since we can't divide by 0
                sum = calculator.Divide(2, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Can't Divide by 0");
                Console.WriteLine(e.ToString());

            }
            catch(Exception otherExceptions)
            {
                Console.WriteLine("\n"+otherExceptions.ToString());
            }
            finally
            {
                Console.WriteLine("\nError Caught");
                Console.WriteLine("\nDo something with error...");
            }
        }
    }

    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x += y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
