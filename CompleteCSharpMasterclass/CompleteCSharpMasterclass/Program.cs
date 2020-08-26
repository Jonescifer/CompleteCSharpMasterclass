using System;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{ 
    class MainClass
    {
        static void Main(string[] args)
        {
            var friendsList = new List<string>{"Frank", "Joe","Michelle" , "Andy", "Maria", "Carlos", "Angelina"};
            var partyFriendsList = GetPartyFriends(friendsList, 4);

            foreach (var name in partyFriendsList)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> listAllFriends, int count)
        {
            var partyFriendsList = new List<string>();
            
            while (partyFriendsList.Count < count)
            {
                var currentFriend = GetPartyFriend(listAllFriends);
                partyFriendsList.Add(currentFriend);
                listAllFriends.Remove(currentFriend); // not clean programing - because we remove from the list we receive - friends.
            }
            return partyFriendsList;
        }
        
        public static string GetPartyFriend(List<string> listFriends)
        {
            string shortestName = listFriends[0];
            for (int i = 0; i < listFriends.Count; i++)
            {
                if (listFriends[i].Length > shortestName.Length)
                {
                    shortestName = listFriends[i];
                }
            }
            return shortestName;
        }
    }
}



    

