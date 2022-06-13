using System;

namespace LambdaExpressions
{
    internal class Program
    {
        /*
         * Lambda expressions create convienence by creating anon functions,
         * this can create shorter code by substituting simple functions
         * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
         */
        static void Main(string[] args)
        {
            //lambda expressions require a delegate.

            //Example 1: Simple argument lambda expression

            //we can use Func to delegate, it takes arguments and returns a result
            //Note: first input is argument data type, second is return data type
            //Note: the lambda expression is number => number*number
            Func<int, int> square = number => number*number;

            Console.WriteLine("Example 1:");
            Console.WriteLine(square(5) +"\n");

            //Example 2: No argument lambda expression
            Func<string> print = () => "someString";
            Console.WriteLine("Example 2:");
            Console.WriteLine(print() +"\n");

            //Example 3: 1 argument lambda expression
            Func<int, int> plusOne = x => ++x;
            Console.WriteLine("Example 3:");
            Console.WriteLine(plusOne(1) +"\n");

            //Example 4: Multiple argument lambda expression
            Func<int, int, int, int> Add = (x, y, z) => x+y+z;
            Console.WriteLine("Example 4:");
            Console.WriteLine(Add(1, 2, 3) +"\n");

        }
    }
}
