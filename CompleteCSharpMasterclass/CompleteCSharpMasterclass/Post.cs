using System;
using System.Reflection;

namespace CompleteCSharpMasterclass
{
    public class Post
    {
        //UNIQUE for the Whole program!!!!
        private static int _currentPostId;
        
        //properties
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }
        
        // "Default constructor. If a derived class does not invoke a base-class constructor explicitly, the default constructor is called implicitly."
        //That's why we will create a constructor ourselves that we control what it does.
        
        public Post()
        {
            this.Id = 0;
            this.Title = "Default Post";
            this.SentByUsername = "John Doe";
            this.IsPublic = true;
        }
        
        //Instance constructor that has 3 parameters.
        public  Post(string title, string sentByUsername, bool isPublic)
        {
            this.Id = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;
        }
        
        protected int GetNextID()
        {
            return ++ _currentPostId;
        }

        public void Update(string title , bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        
        // Virtual method override of the ToString method that is inherited from System.Object. 
        public override string ToString()
        {
            return String.Format("ID: {0} - {1} - by: {2}. " , this.Id, this.Title, this.SentByUsername);
        }
            
    }
}