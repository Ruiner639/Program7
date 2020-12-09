using System;

namespace Program1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day of the week:");
            string day_string = Console.ReadLine();
            Int32.TryParse(day_string, out int day_int);
            Console.WriteLine("Enter what time is it now(hour 0-23):");
            string time_string = Console.ReadLine();
            Int32.TryParse(time_string, out int time_int);
            string day_left = "eror";
            if ((time_int >= 4) && (time_int <= 11))
            {
                time_string = "Good morning, ";
            }
            else if ((time_int >= 12) && (time_int <= 17))
            {
                time_string = "Good afternoon, ";
            }
            else if ((time_int >= 18)&& (time_int <= 23))
            {
                time_string = "Good evening, ";
            }
            else
            {
                time_string = "Good night, ";
            }
            switch (day_string)
            {
                case "1":
                    day_string = "Monday";
                    day_left = "5";
                    break;
                case "2":
                    day_string = "Tuesday";
                    day_left = "4";
                    break;
                case "3":
                    day_string = "Wednesday";
                    day_left = "3";
                    break;
                case "4":
                    day_string = "Thursday";
                    day_left = "2";
                    break;
                case "5":
                    day_string = "Friday";
                    day_left = "1";
                    break;
                case "6":
                    day_string = "Saturday";
                    break;
                case "7":
                    day_string = "Sunday";
                    break;
            }
            if ((day_int >= 6) && (day_int <= 7))
            {
                Console.WriteLine(time_string + " it is a lovely " + day_string + " today. Weekends is here!");
            }
            else
            {
                Console.WriteLine(time_string + " it is a lovely " + day_string + " today. Weekend is coming in " + day_left + " days.");
            }

        }
    }
}
