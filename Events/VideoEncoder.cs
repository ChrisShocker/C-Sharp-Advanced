using System;
using System.Threading;

namespace Events
{
    internal partial class Program
    {
        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }
        }

        public class VideoEncoder
        {
            /*
             * 1. Define a delgate
             * 2. Define an event
             * 3. Raise the event
             */

            /***************************************************************
             * Traditional Step: 1 and 2:
             * 1. Define delegate
             * - Takes two parameters: object that's the source of the event, and any args that have information from the event 
             * 
             *  public delegate void VideoEncodedEventHandler(object source, VideoEventArgs eventArgs);
             *  
             *  
             * 2. Define an event
             * - Note past tense
             *  
             *  public event VideoEncodedEventHandler VideoEncoded; 
             *  
             ***************************************************************  
             *  Modern: Combine Step 1 and 2
             */

            public event EventHandler<VideoEventArgs> VideoEncoded;


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

                //pass video to function
                OnVideoEncoded(video);
            }

            protected virtual void OnVideoEncoded(Video video)
            {
                //Do something after the event is done
                if (VideoEncoded != null)
                {
                    //1st arg is the source of the event or class publishing event
                    //2nd arg is data being sent with the event (none in this case)
                    VideoEncoded(this, new VideoEventArgs() { Video = video });
                }

            }
        }
    }
}
