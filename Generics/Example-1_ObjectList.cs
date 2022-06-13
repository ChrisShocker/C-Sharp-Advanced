using System;

namespace Generics
{
    internal partial class Program
    {
        //Link to Generics Docs
        //https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics


        //Example 1:
        //non-Generic list
        public class ObjectList
        {

            //list to store object
            object[] objectArray = new object[1];

            //Can add anything as an object but suffers in performance due to 
            //having to box and unbox all value types such as an int.
            public void Add(object value)
            {
                Console.WriteLine(value);
                objectArray[0] = value;
                Console.WriteLine("object added");
            }

            //indexer that returns the object at the given index
            public object this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        }
    }
}
