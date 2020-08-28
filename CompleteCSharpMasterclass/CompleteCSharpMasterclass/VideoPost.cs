using System;
using System.Threading;

namespace CompleteCSharpMasterclass
{
    public class VideoPost : Post
    {
        //member fields
        private bool _isPlaying;
        private int _currDuration;
        private Timer _timer;
        //properties
        private string VideoUrl { get; set; }
        private int Length { get; set; }
        
       
        
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
        
        public override string ToString()
        { 
            return
                $"ID: {this.Id} - {this.Title} - {this.VideoUrl} - length: {this.Length} by: {this.SentByUsername}. ";
        }
        
        public void Play()
        {
            if (!_isPlaying) //only if is playin == false you can PLAY.
            {
                _isPlaying = true;
                Console.WriteLine("Playing...");
                _timer = new Timer(TimerCallback,null, 0, 1000);
            }
            
        }
        private void TimerCallback(object state)
        {
            if (_currDuration < Length)//if video is still inside its play range..
            {
                _currDuration++;
                Console.WriteLine("Video at {0}s", _currDuration);// print out current time, its in 1000 milliseconds.
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        
        public void Stop()
        {
            if (_isPlaying) //only if is playin == true you can STOP.
            {
                _isPlaying = false;
                Console.WriteLine("Stopped at second: {0}", _currDuration);//tell user we stopped
                _currDuration = 0;//set current duration to zero again.
                _timer.Dispose();//stops timer cleans and Resets it.
            }
            
        }
        
        
        
    }
}