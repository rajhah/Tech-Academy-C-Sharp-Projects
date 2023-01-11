using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAfterConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time= DateTime.Now;
            Console.WriteLine("The current date and time is: " + time);
            Console.WriteLine("Please enter a whole number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours, the date and time will be {1}.", hours, time.AddHours(hours));
            Console.ReadLine();
        }
    }
}
