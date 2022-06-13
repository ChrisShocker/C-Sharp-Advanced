using System;

namespace Generics
{
    internal partial class Program
    {
        //Example 3:
        //Dictionary with generic class
        public class GenericDictionary<TKey, TValue>
        {
            public void Add(TKey key, TValue value)
            {
                Console.WriteLine("\nExample 3:");
                Console.WriteLine("key: " + key + "value: " + value +"\n");
            }
        }
    }
}
