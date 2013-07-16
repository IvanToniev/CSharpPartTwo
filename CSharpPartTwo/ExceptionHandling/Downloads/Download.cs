using System;
using System.Net;
namespace Download
{
    class Download
    {
       
        static void Main()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "Logo-BASD.jpg");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address is not valid.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}
