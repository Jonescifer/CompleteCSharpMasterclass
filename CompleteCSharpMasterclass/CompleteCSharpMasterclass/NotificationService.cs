using System;
using System.Threading;

namespace CompleteCSharpMasterclass
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine($"The file: {e.File.Title}...is downloaded and unpacked.");
            Thread.Sleep(1000);
        }
    }
}