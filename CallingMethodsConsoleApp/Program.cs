using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hash h = new Hash();
            Console.WriteLine("Please enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number doubled is: " + h.Multiply(num));
            Console.WriteLine("Your number reversed is: " + h.Reverse(num));
            Console.WriteLine("The square root of your number is close to: " + h.SquareRoot(num));
            Console.ReadLine();
        }
    }
}
