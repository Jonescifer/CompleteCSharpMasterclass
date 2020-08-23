using System;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{ 
    class MainClass
    {
        static void Main(string[] args)
        {
            var friends = new List<string>{"Frank", "Joe","Michelle" , "Andy", "Maria", "Carlos", "Angelina"};
            var partyFriend = GetPartyFriends(friends, 2);

            foreach (var name in partyFriend)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();
            
            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend); // not clean programing - because we remove from the list we receive - friends.
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



    

