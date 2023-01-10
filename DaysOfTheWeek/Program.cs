using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week: ");

            bool validDay = false;
            while (!validDay)
            {
                // Wrap the above statement in a try/catch block
                try
                {
                    // Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);

                    Console.WriteLine("Day of the week is: " + day.ToString());
                    Console.ReadLine();
                    validDay = true;
                }
                catch (Exception)
                {
                    //and have it print "Please enter an actual day of the week.” to the console if an error occurs.
                    Console.WriteLine("Please enter an actual day of the week:");
                }
            }
        }
        // Create an enum for the days of the week.
        public enum DaysOfTheWeek {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }
    }
}
