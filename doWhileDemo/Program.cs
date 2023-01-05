using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileDemo
{
    internal class Program
    {
        static void Main()
        {
            bool key = false;
            
            // loop until the user presses a key
            while (!key)
            {
                Console.WriteLine("Please press a key");
                key = Console.KeyAvailable;
            }
            Console.WriteLine("You have escaped the madness of the loop.");
            Console.ReadKey(true);

            //loop until the user enters the correct answer to escape the program
            do
            {
                Console.WriteLine("Do you wish to leave for good? (Y/N)");
                string s = Console.ReadLine();
                if (s.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You are leaving for good. Use what time you have wisely.");
                    key = false;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("WRONG ANSWER");
                }
            }
            while (key);
            
        }
    }
}
