using System;

namespace Generics
{
    internal partial class Program
    {

        public class Utilities
        {

          
            //Example 4a:
            //Apply a constraint for typical behavior
            public int Max(int a, int b)
            {
                return a > b ? a : b;
            }

            //Example 4b:
            //Generic type won't work, since the input type is unknown,
            //and comparisons don't work with all types
            //we must create a generic function and use IComparable to make sure inputs are comparable
            public T Max<T>(T a, T b) where T : IComparable
            {
                return a.CompareTo(b) > 0 ? a : b;
            }

            /*
             *Note: We can also move the IComparable to class i.e.,
             *'public class Utilities where T : IComparable'
             *
             *and the function would no longer need it i.e.,
             *public T Max(T a, T b){
                return a.CompareTo(b) > 0 ? a : b;
              }
             * 
             */
        }
    }
}
