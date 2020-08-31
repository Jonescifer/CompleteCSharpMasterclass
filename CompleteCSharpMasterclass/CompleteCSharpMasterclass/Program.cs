using System;
using System.CodeDom;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{ 
    class MainClass
    {
        static void Main(string[] args)
        { 
            /*
            var post1 = new Post();
            Console.WriteLine(post1.ToString());
            
            var post2 = new Post("Thanks for the bDay wishes!", "Paul Wolf", true);
            Console.WriteLine(post2.ToString());
            
            post2.Update("you know what? forget it, Franco!", true);
            Console.WriteLine(post2.ToString());
            
            var imagePost1 = new ImagePost("check out my new helmet!" , "Paul Wolf", "https://phinemo.com/beginilah-maaf-jika-diucapkan-dengan-bahasa-lain-di-dunia/dfghh/", true);
            Console.WriteLine(imagePost1.ToString());
            */
            var videoPost1 = new VideoPost("run the jewels" , "Paul Wolf" , "https://www.youtube.com/watch?v=rONyX2-nQ5A" , 5 , true );
            Console.WriteLine(videoPost1.ToString());
            
            
            videoPost1.Play();
            Console.WriteLine("press any key to stop...");
            Console.ReadKey();
            videoPost1.Stop();
            

        }
    }
}



    

