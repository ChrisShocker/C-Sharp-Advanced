using System;
using System.Threading;

namespace Events
{
    internal partial class Program
    {
        public class VideoEncoder
        {
            /*
             * 1. Define a delgate
             * 2. Define an event
             * 3. Raise the event
             */

            /*
             * 1. Define delegate
             * - Takes two parameters: object that's the source of the event, and any args that have information from the event 
             */
            public delegate void VideoEncodedEventHandler(object source, EventArgs eventArgs);

            /*
             * 2. Define an event
             * - Note past tense
             */
            public event VideoEncodedEventHandler VideoEncoded; 

            /*
             * 3. Raise the Event
             * - Need a method to handle raising the event
             *      - Start with "On"
             *      - Method must be virtual
             *      - Method must be void
             */

                

            public void Encode(Video video)
            {
                Console.WriteLine("Encoding video...");
                Thread.Sleep(3000);

                OnVideoEncoded();
            }

            protected virtual void OnVideoEncoded()
            {
                //Do something after the event is done
                if(VideoEncoded != null)
                {
                    //1st arg is the source of the event or class publishing event
                    //2nd arg is data being sent with the event (none in this case)
                    VideoEncoded(this, EventArgs.Empty);
                }

            }
        }
    }
}
