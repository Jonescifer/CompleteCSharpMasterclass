using System;
using System.Threading;

namespace CompleteCSharpMasterclass
{
    public class DownloadHelper
    {
        //Step 1 - create a delegate.
        //public delegate void FileDownloadedEventHandler(object source, FileEventArgs args );
        //C# has created an Event handler to make it easy for developers.. its called EventHandler.. so no need for step 1.
        
        //Step 2 - create an event based on that delegate.
        public event EventHandler<FileEventArgs> FileDownloaded;
        
        //Step 3 - raise the event.
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this,new FileEventArgs(){File = file});
            }
        }
        public void Download(File file)
        {
            Console.WriteLine($"Downloading file: {file.Title}...");
            Thread.Sleep(4000);
            //Step 3.1
            OnFileDownloaded(file);
        }
        
    }
}