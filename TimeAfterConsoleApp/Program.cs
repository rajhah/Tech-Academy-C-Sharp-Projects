using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TimeAfterConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time= DateTime.Now;
            // Print the current date and time to the console.
            Console.WriteLine("The current date and time is: " + time);
            // Ask the user for a number.
            Console.WriteLine("Please enter a whole number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            // Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("In {0} hours, the date and time will be {1}.", hours, time.AddHours(hours));
            Console.ReadLine();
        }
    }
}
