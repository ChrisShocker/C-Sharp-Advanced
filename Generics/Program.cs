using System;

namespace Generics
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            
            //Example 1:
            //Non-Generic Example

            //create list
            var ObjectList = new ObjectList();

            //create an object to add to list
            var person = new { name = "joe", Age = 21 };

            //add created object to list
            ObjectList.Add(person);


            //Example 2:
            //Generic Example

            //create the generic list specifying the type
            var numbers = new GenericList<int>();
            //add a value
            numbers.Add(1);

            //create the generic list specifying the type
            var list = new GenericList<object>();
            //add an object
            list.Add(new object());


            //Example 3:

            //Generic Dictionary Example
            var dictionary = new GenericDictionary<string, object>();
            dictionary.Add("123", new object());


            //Example 4 Value Constraint:
            var number = new Nullable<int>(5);
            Console.WriteLine("Example 4: Value Constraints");
            Console.WriteLine("Has Value: " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());


        }
    }
}
