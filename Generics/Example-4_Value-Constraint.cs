namespace Generics
{
    internal partial class Program
    {
        //Example 4: constraint to value type "struct"
        //value types can't be null
        public class Nullable<T> where T : struct
        {
            private object _value;

            //default constructor
            public Nullable()
            {
            }

            public Nullable(T value)
            {
                _value = value;
            }

            //return true if the object has a value
            public bool HasValue
            {
                //return true if value isn't null
                get { return _value != null; }
            }

            //return object value else default value
            public T GetValueOrDefault()
            {
                if (HasValue)
                {
                    //cast/unbox value since _object is an object
                    return (T) _value;
                }

                return default(T);
            }

        }
    }
}
