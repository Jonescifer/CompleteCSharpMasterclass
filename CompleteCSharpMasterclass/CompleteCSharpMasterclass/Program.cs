using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            
            // //random dice face
            // var randomDice = new Random();
            // int numEyes;
            // for (var i = 0; i < 10; i++)
            // {
            //     numEyes = randomDice.Next(1, 7);
            //     Console.WriteLine(numEyes);
            // }
            //

            //fortune teller
            Console.WriteLine("Ask me a question..");
            Console.ReadLine();
            
            var randomAnswer = new Random();
            var answeNum = randomAnswer.Next(1, 4);

            switch (answeNum)
            {
                case 1:
                    Console.WriteLine("yes");
                    return;
                case 2:
                    Console.WriteLine("maybe");
                    return;
                case 3:
                    Console.WriteLine("no");
                    return;
            }
        }
    }
}



    

