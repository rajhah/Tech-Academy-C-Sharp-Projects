using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TimeAfterConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * DATETIME ASSIGNMENT
             */

            DateTime time = DateTime.Now;
            // Print the current date and time to the console.
            Console.WriteLine("The current date and time is: " + time);
            // Ask the user for a number.
            Console.WriteLine("Please enter a whole number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            // Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("In {0} hours, the date and time will be {1}.", hours, time.AddHours(hours));
            Console.ReadLine();

            /* 
             * CONSTRUCTOR ASSIGNMENT
             */

            // Create a const variable.
            const string rock = "rock";
            Console.WriteLine("The value of rock is \"{0}\"", rock);

            // Create a variable using the keyword “var.”
            var constructed = new ManyConstructors();
            Console.WriteLine(constructed.ToString());
            Console.ReadLine();
            var newConstructed = new ManyConstructors(9, "another string");
            Console.WriteLine(newConstructed.ToString());
            Console.ReadLine();
        }

        public class ManyConstructors
        {
            public int Value { get; set; }
            public string S { get; set; }

            // Chain two constructors together.
            public ManyConstructors() : this(0, "string")
            {
            }
            public ManyConstructors(int value, string s)
            {
                Value = value;
                S = s;
            }
            public override string ToString()
            {
                return string.Format("Value is: {0}\nString is: {1}", Value, S);
            }

        }
    }
}
