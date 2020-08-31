using System;
using System.Threading;


namespace CompleteCSharpMasterclass
{
    public class VideoPost : Post
    {
        //member fields
        private bool _isPlaying = false;
        private int _secondCounter;
        private Timer _timer; // As long as you are using a Timer, you must keep a reference to it. As with any managed object, a Timer is subject to garbage collection when there are no references to it. The fact that a Timer is still active does not prevent it from being collected.
        
        
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
            if (!_isPlaying)
            {
                _isPlaying = true;
                Console.WriteLine("Play has commenced");
                _timer = new Timer(TimerCallback, null, 0, 1000);
                
            }
            
        }

        private void TimerCallback(object state)
        {
            if (_secondCounter < Length)
            { 
                _secondCounter++;
               Console.WriteLine("{0} seconds passed.", _secondCounter);
               GC.Collect();// force garbage collection.. why? dont know yet..
                
            }
            else
            { 
                Stop();// need to stop! 
            }
        }

        public void Stop()
        {
            if (_isPlaying)
            {
                _isPlaying = false;
                Console.WriteLine("play has ended at second: {0}.", _secondCounter);
                _timer.Dispose(); //Releases all resources used by the current instance of Timer.
            }
        }
    }
        
        
        
}

