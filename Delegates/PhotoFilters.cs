using System;

namespace Delegates
{

    internal partial class Program
    {
        public class PhotoFilters
        {
            public void ApplyBrightness(Photo photo)
            {
                Console.WriteLine("Brightness Applied");
            }

            public void ApplyContrast(Photo photo)
            {
                Console.WriteLine("Constrast Applied");
            }

            public void Resize(Photo photo)
            {
                Console.WriteLine("Resize Applied");
            }
        }
    }
}
