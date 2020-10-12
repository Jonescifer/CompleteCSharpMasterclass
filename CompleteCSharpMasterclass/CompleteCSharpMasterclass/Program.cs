using System;
using System.ComponentModel;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        
        private static void Main(string[] args)
        {
            var file1 = new File(){Title = "File 1"};// new file created and also set Title property 
            var downloadHelper = new DownloadHelper();//publisher
            var unpackService = new UnpackService();//receiver
            var notificationService = new NotificationService();//receiver
            
            //subscribe 2 classes to FileDownloaded event.
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;
            
            downloadHelper.Download(file1);
            
        }
    }
        
}




    

