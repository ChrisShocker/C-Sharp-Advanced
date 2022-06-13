using System;

namespace Generics
{
    internal partial class Program
    {
        //Example 2:
        /*
         * Generic List
         * - Parameters specified with < >
         * - Typically parameters are named T ie <T> where T is for Template or Type
         */

        public class GenericList<T>
        {
            public void Add(T value)
            {
                Console.WriteLine("\nExample 2:");
                Console.WriteLine(value);
            }
            public T this[int index]
            {
                get { throw new NotImplementedException(); }
            }

        }
    }
}
