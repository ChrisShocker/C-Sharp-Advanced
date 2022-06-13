using System;

namespace Generics
{
    internal class Program
    {
        //non-Generic list
        public class ObjectList
        {
            //Can add anything as an object but suffers in performance due to 
            //having to box all value types such as an int.
            public void Add(object value)
            {
                throw new NotImplementedException();
            }

            //indexer that returns the object at the given index
            public object this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
