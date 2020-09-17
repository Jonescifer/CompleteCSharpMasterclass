using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            //the pattern to find: /d -> numbers
            string patternToFind = @"\d";//@"\d{10} //@"number"
            string text = "Hi my number is 0502226940";
            var rx = new Regex(patternToFind);

            MatchCollection matchCollection = rx.Matches(text);
            
            Console.WriteLine($"{matchCollection.Count} hits where found in: {text}.");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} appeared at index number: {group[0].Index}");
            }
            
        }
    }
}



    

