using System;
using System.Timers;

namespace CompleteCSharpMasterclass
{
    public class VideoPost : Post
    {
        private string VideoUrl { get; set; }
        private int Length { get; set; }
        
        private static Timer _videoTimer = new Timer();
        
        public VideoPost(){} // if we have an empty constructor - then the BASE class, (e.g. Post) constructor will be called! this one -> public Post(){this.Id = 0;this.Title = "Default Post";this.SentByUsername = "John Doe";this.IsPublic = true;}

        public VideoPost(string title , string sentByUsername , string videoUrl ,int length , bool isPublic )
        {
            this.Id = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;
            //members of VideoPost, but not of Post.
            this.VideoUrl = videoUrl;
            this.Length = length;
        }
        
        //return an overide ToString...
        public override string ToString()
        {
            return string.Format("ID: {0} - {1} - {2} - length: {3} by: {4}. ", this.Id, this.Title, this.VideoUrl, this.Length, this.SentByUsername);
        }
        
    }
}