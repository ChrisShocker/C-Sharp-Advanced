namespace Generics
{
    internal partial class Program
    {
        //Example 4:
        //sometimes we may need to restrain input types

        public class Product
        {
            public string Title { get; set; }
            public float Price { get; set; }
        }

        public class Book: Product
        {
            public string Name { get; set; }
        }

        //since the generic class is contrained to the Product class,
        //we have access to all it's properties/methods
        public class DiscountCalculator<TProduct> where TProduct : Product
        {
            public float CalcualtePrice(TProduct product)
            {
                return product.Price;

            }
        }
    }
}
