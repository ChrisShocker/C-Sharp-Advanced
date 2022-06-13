using System;

namespace Generics
{
    internal class Program
    {

        //Link to Generics Docs
        //https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics

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


        /*
         * Generic List
         * - Parameters specified with < >
         * - Typically parameters are named T ie <T> where T is for Template or Type
         */

        public class GenericList<T>
        {
            public void Add(T value)
            {

            }
            public T this[int index]
            {
                set { throw new NotImplementedException(); }
            }

        }



        static void Main(string[] args)
        {
            //Non-Generic Example

            //create list
            var ObjectList = new ObjectList();

            //create an object to add to list
            var person = new { name = "joe", Age = 21 };

            //add created object to list
            ObjectList.Add(person);


            //Generic Example

            //create the generic list specifying the type
            var numbers = new GenericList<int>();
            //add a value
            numbers.Add(1);

            //create the generic list specifying the type
            var list = new GenericList<object>();
            //add an object
            list.Add(new object());

        }
    }
}
