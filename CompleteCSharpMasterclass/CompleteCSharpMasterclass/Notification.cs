using System;

namespace CompleteCSharpMasterclass
{
    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        //default constructor
        public Notification()
        {
            sender = "default Joe";
            message = "default message";
            date = "default date";
        }
        
        
        public Notification(string sender, string message, string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }

        public void ShowNotification()
        {
            Console.WriteLine($"hi im {sender}, my message is {message}, the date is {date}");
        }
        public string GetDate()
        {
            return this.date;
        }
        
    }
}