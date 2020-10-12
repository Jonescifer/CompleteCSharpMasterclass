using System;
using System.Threading;

namespace CompleteCSharpMasterclass
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine($"UnpackerService: unpacking the file: {e.File.Title}...");
            Thread.Sleep(1000);
        }
    }
}