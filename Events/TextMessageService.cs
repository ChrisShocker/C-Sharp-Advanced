using System;

namespace Events
{
    internal partial class Program
    {
        //4. Create a subsriber to handle sending texts
        public class TextMessageService
        {
            public void OnVideoEncoded(object source, EventArgs eventargs)
            {
                Console.WriteLine("MessageService: Sending a text message");
            }
        }
    }
}
