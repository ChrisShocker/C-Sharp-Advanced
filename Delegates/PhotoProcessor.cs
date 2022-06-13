namespace Delegates
{

    internal partial class Program
    {


        public class PhotoProcessor
        {

            //create the delegate, holds a pointer to a function or group of functions
            public delegate void PhotoFilterhandler(Photo photo);

            //pass the delegate into the function
            public void Process(string path, PhotoFilterhandler filterHandler)
            {
                var photo = Photo.Load(path);

                //filter handler is now responsible for handeling what filters to apply
                filterHandler(photo);

                photo.Save();
            }
        }
    }
}
