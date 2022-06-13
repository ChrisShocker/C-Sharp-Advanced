using System;

namespace Generics
{
    internal partial class Program
    {
            //Example 4: Two Constraints,
            //Two constraints can be applied to generic classes
        public class TwoConstraints<T> where T : IComparable, new()
        {
            //If we need to instantiate an instance of T
            //
            public void DoSomethingWithObject(T value)
            {
                //need a default constructor so apply another constraint for the default contstructor ie, new() as second constraint type
                var obj = new T();
            }
        }
    }
}
