using System;
using System.CodeDom;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{ 
    class MainClass
    {
        static void Main(string[] args)
        {
            var friendsList = new List<string>{"Frank", "Joe","Michelle" , "Andy", "Maria", "Carlos", "Angelina"};
            //var friendsList = new List<string>(); //empty list exception..
            //var partyFriendsList = GetPartyFriends(friendsList, -1); // -1 coun exception..
            //var partyFriendsList = GetPartyFriends(null, 3); // null exception.. giving no object where list object is expected..
            var partyFriendsList = GetPartyFriends(friendsList, 3);

            /* bug check
            foreach (var name in friendsList)
                Console.WriteLine(name);
            Console.WriteLine("______________________");
            */
            
            foreach (var name in partyFriendsList)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> friendsList, int count)
        {
            if (friendsList == null)
            {
                throw new ArgumentNullException("friendList", "list cant be Null, Yaanu Empty...");
            }
            if (friendsList.Count < count || count <= 0 || friendsList.Count < 0)
            {
                throw new ArgumentOutOfRangeException("count" , "count cant be greater than elements in the list,zero or lesser!.\nBIATCH!");
                
            }
            var bufferList = new List<string>(friendsList); // created a buffer -  a list that gets the listAllFriends list's elements. NOW when i delete a freind from the list in line 26. i do it form the bufferList list and not friendList.
            var partyFriendsList = new List<string>();
            
            while (partyFriendsList.Count < count)
            {
                var currentFriend = GetPartyFriend(bufferList);
                partyFriendsList.Add(currentFriend);
              //listAllFriends.Remove(currentFriend); // not clean programing - because we remove from the list we receive - friendsList.
                bufferList.Remove(currentFriend);
            }
            return partyFriendsList;
        }
        
        
        /// <summary>
        /// this is a logic to figure out who is a party friend
        /// </summary>
        /// <param name="listFriends"></param>
        /// <returns></returns>
        public static string GetPartyFriend(List<string> listFriends)
        {
            string shortestName = listFriends[0];
            for (int i = 0; i < listFriends.Count; i++)
            {
                if (listFriends[i].Length < shortestName.Length)
                {
                    shortestName = listFriends[i];
                }
            }
            return shortestName;
        }
    }
}



    

