using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            var dateTime = new DateTime(1979, 06, 27, 08, 00, 00);

            Console.WriteLine($"My birthday is on: {dateTime}.");

            // write today on screen
            Console.WriteLine(DateTime.Today);
            
            //write today AND current LOCAL time on screen
            Console.WriteLine(DateTime.Now);
            
            //write today AND current UTC time on screen
            Console.WriteLine(DateTime.UtcNow);
            
            //get the day of tomorrow..
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"tomorrow is: {tomorrow}");
            
            //get day of week today..
            Console.WriteLine(DateTime.Now.DayOfWeek);
            
            //get first day of year..
            var year = 1979;
            Console.WriteLine($"The first day of {year} is: {GetFirstDayOfYear(year)}");
            Console.WriteLine(DateTime.DaysInMonth(year,1));
            
            //get number of days in a specific month in a specific year.
            var days = DateTime.DaysInMonth(1978,6);
            Console.WriteLine($"june of 1978 has {days} days.");
            
            //get todays date time in a specific manner
            DateTime now = DateTime.Now; //.AddDays(11)
            Console.WriteLine($"minute {now.Minute}");
            
            
            
            //display the time in this structure x oclock y minutes and z seconds

            Console.WriteLine($"the time is: {now.Hour} hours, {now.Minute} minutes and {now.Second}.");

            Console.WriteLine("write a date in this format: yyy-mm-dd");
            string input = Console.ReadLine();
            
            if (DateTime.TryParse(input, out DateTime dateTimeUser))
            {
                Console.WriteLine(dateTimeUser);
                TimeSpan daysPassed = now.Subtract(dateTimeUser);
                Console.WriteLine($"{daysPassed.Days} days have passes since {dateTimeUser}");
            }
            else
            {
                throw new Exception("wrong input mate!");
            }
            
            Console.WriteLine($"enter a number of days you want to know back from today as a date");
            
            //58 days ago i was 15000 days old. on 21.07.2020
            int intInput1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(GetDateNDaysAgo(intInput1, now));
            
            Console.WriteLine($"enter a number of days you want to know from today as a date");
            
            //days to go in the future
            int intInput2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(GetDateNDaysTogo(intInput2, now));
        }
        //get tomorrow
        static DateTime GetTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }
        //get first day of the year
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year,1 ,1 );
        }
        //what date was N days ago!
        static string GetDateNDaysAgo(int days , DateTime now)
        {
            DateTime dateNDaysAgo = now.AddDays(-(days));
            
            return dateNDaysAgo.ToString(CultureInfo.CurrentCulture);
        }
        static string GetDateNDaysTogo(int days , DateTime now)
        {
            DateTime dateNDaysAgo = now.AddDays(days);
            
            return dateNDaysAgo.ToString(CultureInfo.CurrentCulture);
        }
    }
}



    

