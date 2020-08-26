using System;

namespace CompleteCSharpMasterclass
{
    
    // ImagePost derived from Post and adds a property (ImageURL) and two constructors.
    class ImagePost : Post
    {
        public string ImageUrl { get; set; }


        public ImagePost() { }

        public ImagePost(string title , string sentByUsername , string imageUrl , bool isPublic)
        {
            //use properties and method from Post class!!!! inheritance!!!!!!!muahahahahahahahahahaha!!!!!!!
            this.Id = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;
            
            //property ImageUrl is a member of ImagePost but not of Post!!!!!!
            this.ImageUrl = imageUrl;
        } 
        
        // Virtual method OVERRIDE override of the ToString method that is inherited from POST!   omg!!!
        public override string ToString()
        {
            return String.Format("ID: {0} - {1} - {2} by: {3}. " , this.Id, this.Title, this.ImageUrl ,this.SentByUsername);
        }

    }
}