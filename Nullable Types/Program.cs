using System;

namespace Nullable_Types
{
    /*
     * Nullable Types
     * - C# value type can't be NULL,
     *   but in some cases a value should be NULL ie, secondary phone number
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Value types can't be set to null
             * ie 'int secondaryPhone = null' will throw an exception
             * - We can use the Nullabe generic
             */

            //Use Nullable generic longhand
            Nullable<int> secondaryPhone = null;

            secondaryPhone = 1;

            if (secondaryPhone.HasValue)
                Console.WriteLine("Secondary Phone number: " +secondaryPhone.Value);

            //or shorthand
            int? secondaryPhone2 = null;

            if (!secondaryPhone2.HasValue)
            {
                Console.WriteLine("secondaryPhone2 is null");

            }


            
        }
    }
}
