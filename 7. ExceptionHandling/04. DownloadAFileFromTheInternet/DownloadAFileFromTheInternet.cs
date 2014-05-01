//Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

namespace _04.DownloadAFileFromTheInternet
{
    class DownloadAFileFromTheInternet
    {
        static void Main()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "logo.jpg");
                }

                catch (ArgumentNullException)
                {
                    Console.Error.WriteLine("Should not be null");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid or there is no internet connection.");
                }

                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}
