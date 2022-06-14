using System;
using System.Collections.Generic;

namespace Custom_Exceptions
{
    /*
     * Custom Exceptions
     * - A tool that can allow quicker debugging.
     *  - Handle exceptions at lower layers,
     *    to prevent them from being affecting higher layers
     *   
     * - Custom exceptions extend the C# Exceptions class
     *      - Pass in a message and an innerException to
     *          - Call parent construct with those arguments
     *   
     * https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            var api = new YouTubeApi();
            var videos = api.GetVideos("break");
        }
    }


    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Thrown custom exception");
            }
            catch (Exception ex)
            {
                throw new CustomException("\nThrown custom exception", ex);
            }
        }
    }

    public class Video
    {
        public string Name { get; set; }

    }
}
