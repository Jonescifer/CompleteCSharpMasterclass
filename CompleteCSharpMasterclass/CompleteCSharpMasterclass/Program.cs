using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var friends = new List<string>{"Frank", "Joe","Michelle" , "Andy", "Maria", "Carlos", "Angelina"};
            var partyFriend = GetPartyFriends(friends, 3);

            foreach (var name in partyFriend)
            {
                Console.WriteLine(name);
            }
            
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();
            
            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > shortestName.Length)
                {
                    shortestName = list[i];
                }
            }

            return shortestName;
        }
    }
}



    

