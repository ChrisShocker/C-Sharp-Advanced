using System;

namespace Events
{
    internal partial class Program
    {

        /*
         * Events allow objects to trigger one another, 
         * and allow applications to be more loosely coupled
         * 
         * Typical Event Flow:
         * 1. Define a delgate
         *   - Takes two parameters: object that's the source of the event, and any args that have information from the event 
         *   
         * 2. Define an event
         *   - Note tense is important
         * 
         * 3. Raise the event
         *  - Need a method to handle raising the event
         *    - Method starts with "On"
         *    - Method must be virtual
         *    - Method must be void
         * 
         * 4. Create event handler
         *  - Create Subscription
         * 
         * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event
         */

        static void Main(string[] args)
        {
            //create a video and give it a title
            var video = new Video() { Title = "Video 1" };

            //instantiate VideoEncoder
            //Publisher
            var videoEncoder = new VideoEncoder();

            //instantiate MailService
            //Subscriber
            var mailService = new MailService();

            //4. Create Subscription using the delegate
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            //call encode
            videoEncoder.Encode(video);
        }

        //4.Create Event handler
        public class MailService
        {
            public void OnVideoEncoded(object source, EventArgs e)
            {
                Console.WriteLine("MailService: Sending an email...");
            }
        }
    }
}
