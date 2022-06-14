using System;
using System.IO;

namespace Memory_Management
{
    /*
     * Memory Management 
     * - Unmanaged Resources must be closed manually, 
     *   since they're not cleared with the default garbage collector.
     *      - Files, Database connections, Network Connections, Graphic Handles, etc must be closed manually
     *  
     *  - Unamanged resources are closed with Dispose or their default disposal method ie, Close()
     *  
     * https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                //open unmanaged resource
                streamReader = new StreamReader("path");
            }
            catch (Exception)
            {
                Console.WriteLine("An exception is caught");
            }
            finally
            {
                /*
                 * If the streamReader was created, dispose of it
                 * 
                 * Note: .Close can also be used on streamReader, 
                 * it calls Dispose automatically.
                 */
                if(streamReader != null)
                    streamReader.Dispose();
                Console.WriteLine("\nResource closed");
            }


            /********************************************************************/
            Console.WriteLine("\nUsing Example");
            try
            {
                Console.WriteLine("\nUsing automatically disposes of unusmanaged resource");
                //Using automatically creates a finally block and disposes of the unmanaged resource.
                using (streamReader = new StreamReader("path"));
            }
            catch (Exception)
            {
                Console.WriteLine("An exception is caught");
            }
        }
    }
}
