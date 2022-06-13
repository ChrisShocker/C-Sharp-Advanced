using System;

namespace Events
{
    internal partial class Program
    {
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
