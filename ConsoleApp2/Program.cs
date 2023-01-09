using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CONSOLE APP ASSIGNMENT PART 1
            */

            // Create a one-dimentional array of strings:
            string[] stringArray = { "1: ", "2: ", "3: ", "4: ", "5: ", "6: ", "7: ", "8: ", "9: "};

            //Ask the user to input some text
            Console.WriteLine("Input some text: ");
            string addText = Console.ReadLine();

            // Add user's text to each element of the string array
            for (int i=0; i<stringArray.Length; i++)
            {
                stringArray[i] += addText.Trim();
            }

            // Print off each string in the array one at a time
            for (int i=0; i<stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.ReadLine();

            /*
            CONSOLE APP ASSIGNMENT PART 2
            */

            int infinite = 0;
            // Add an ininite loop
            while (true)
            {
                infinite++;
                
                // Fix the infinite loop so that it will execute properly
                // Added a break condition to end the loop

                if (infinite > 10000)
                {
                    Console.WriteLine(infinite);
                    break;
                }
            };

            Console.ReadLine();

            /*
            CONSOLE APP ASSIGNMENT PART 3
            */

            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            int lessThanLoop = 0;
            while (lessThanLoop < 4)
            {
                Console.WriteLine(lessThanLoop);
                lessThanLoop++;
            }
            Console.ReadLine();

            // Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            lessThanLoop = 0;
            while (lessThanLoop <= 4) {
                Console.WriteLine(lessThanLoop);
                lessThanLoop++;
            }

            /*
            CONSOLE APP ASSIGNMENT PART 4
            */

            // A list of strings where each item in the list is unique.
            List<string> list = new List<string> { "Alpha", "Bravo", "Charlie", "Delta", "Echo" };

            // Ask the user to input text to search for in the list.
            Console.WriteLine("Enter search text: (hint: \"Alpha\", \"Bravo\", \"Charlie\", \"Delta\", \"Echo\")");
            string searchText = Console.ReadLine();

            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            bool found = false;
            foreach (string str in list)
            {
                if (str.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // This whole block of code can be done much simpler without a hand-made loop to iterate over every item
                    Console.WriteLine(list.IndexOf(str));
                    found = true;
                    // Add code that stops the loop from executing once a match has been found.
                    break;
                }
            }
            if (!found)
            {
                // Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
                Console.WriteLine("Item was not found in list.");
            }

            Console.ReadLine();

            /*
            CONSOLE APP ASSIGNMENT PART 5
            */

            // A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> identicalStrings = new List<string> { "Alpha", "Alpha", "Bravo", "Charlie", "Delta", "Delta" };
            Console.WriteLine("Enter search text: (hint: \"Alpha\", \"Alpha\", \"Bravo\", \"Charlie\", \"Delta\", \"Delta\")");
            searchText = Console.ReadLine();

            // Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text.
            // Ensure to remove any break statements that may prevent your code from returning multiple matches.
            for (int i = 0; i < identicalStrings.Count; i++)
            {
                if (identicalStrings[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }
            
            // Add code to the loop to check if the user put in text that isn't on the list and, if they did,
            // tells the user their input is not on the list
            if (!found)
            {
                Console.WriteLine("Item was not found in list.");
            }

            Console.ReadLine();

            /*
            CONSOLE APP ASSIGNMENT PART 6
            */

            // Create a list of strings that has at least two identical strings in the list.
            // List<string> identicalStrings = new List<string> { "Alpha", "Alpha", "Bravo", "Charlie", "Delta", "Delta" };

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and 
            //whether or not it has already appeared in the list.
            List<string> uniqueStrings = new List<string>();
            foreach (string str in identicalStrings)
            {
                if (uniqueStrings.Contains(str)){
                    Console.WriteLine(str + " - this item is a duplicate.");
                }
                else
                {
                    Console.WriteLine(str + " - this item is unique.");
                }
                uniqueStrings.Add(str);
            }

            Console.ReadLine() ;    
        }
    }
}
