using System;

namespace Events
{
    internal partial class Program
    {
        //4.Create Event handler
        public class MailService
        {
            public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
            {
                Console.WriteLine("Video Title: "  +eventArgs.Video.Title);
                Console.WriteLine("MailService: Sending an email...");
            }
        }
    }
}
