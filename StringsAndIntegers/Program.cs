using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<int> numbers = new List<int>() { 6, 18, 7, 99, 2045 };
                Console.WriteLine("Enter a number by which to divide every number in this list: ");
                Console.WriteLine("6, 18, 7, 99, 2045");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here is the result:");
                string dividend = "";
                foreach (int i in numbers)
                {
                    dividend += ((i / divisor) + ", ");
                }
                Console.WriteLine(dividend.TrimEnd(' ', ','));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Exited from try/catch block");
            Console.ReadLine();
        }
    }
}
