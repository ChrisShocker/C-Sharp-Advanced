using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**********************************************************************************************/

        //Async Version
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //await DownloadHTMLAsync("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/");
            var getHtmlTask = GetHtmlAsync("http://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/");
            var html = await getHtmlTask;
            MessageBox.Show("html Downloaded");
        }

        public async Task DownloadHTMLAsync(string url)
        {
            var webClient = new WebClient();

            //returns a byte array of the downloaded resource
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Programming\C#\C-Sharp-Advanced\Async"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }

        /**********************************************************************************************/

        /*
        //Sync Version
        private void Button_Clicks(object sender, RoutedEventArgs e)
        {
            DownloadHTML("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/");
        }

        public void DownloadHTML(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Programming\C#\C-Sharp-Advanced\Async"))
            {
                streamWriter.Write(html);
            }
        }
        */
    }
}
