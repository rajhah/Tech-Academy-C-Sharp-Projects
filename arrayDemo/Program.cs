using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace arrayDemo
{
    internal class Program
    {
        static void Main()
        {
            //initializing variables to be referenced later
            string[] stringArray = { "first element", "second element", "third element", "fourth element", "fifth element" };
            int[] intArray = { 1, 2, 3, 4, 5 };
            List<string> stringList = new List<string>();
            stringList.Add("first List element");
            stringList.Add("second List element");
            stringList.Add("third List element");
            stringList.Add("fourth List element");
            stringList.Add("fifth List element");


            //loop to continue asking user for which option they want to select until exit
            char exit = '0';
            while (exit != '4')
            {
                Console.WriteLine("Pick a path: \n[1] Array of Strings\n[2] Array of Integers\n[3] List of Strings\n[4] exit");
                ConsoleKeyInfo key = Console.ReadKey();
                exit = key.KeyChar;

                int i;
                //pick an index, whichever is chosen that element will be returned.
                switch (exit)
                {
                    case '1':
                        i = getIndex();
                        Console.WriteLine("The string at index " + i + " is: " + stringArray[i]);
                        break;
                    case '2':
                        i = getIndex();
                        Console.WriteLine("The integer at index " + i + " is: " + intArray[i]);
                        break;
                    case '3':
                        i = getIndex();
                        Console.WriteLine("The string at index " + i + " is: " + stringList[i]);
                        break;
                    case '4':
                        Console.WriteLine("\nHave a nice day!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\nSomething went wrong. Goodbye.");
                        exit = '4';
                        break;
                }
            }

            // dirty function to get the index number and validate that it is within correct range
            int getIndex()
            {
                int index;
                do
                {
                    Console.WriteLine("\nPick an index (0-4):");
                    index = Convert.ToInt32(Console.ReadLine());
                    if (index > 4 || index < 0)
                    {
                        Console.WriteLine("Invalid index!");
                    }
                }
                while (index > 4 || index < 0);
                
                return index;
            }
        }
    }
}
