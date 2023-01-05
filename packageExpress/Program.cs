using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageExpress
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter the weight (in pounds) of the package you are shipping:");
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the width (in inches) of your package:");
                float width = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the height (in inches) of your package:");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the length (in inches) of your package:");
                float length = Convert.ToSingle(Console.ReadLine());
                if(width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    float quote = ((width * height * length) * weight) / 100;
                    Console.WriteLine("You estimated shipping total is: $" + quote.ToString("N2"));
                    Console.ReadLine();
                }
            }
        }
    }
}
