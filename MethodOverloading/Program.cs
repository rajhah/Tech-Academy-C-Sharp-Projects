using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * MAIN METHOD SUBMISSION ASSIGNMENT
             */

            Overloader o = new Overloader();

            Console.WriteLine("Enter a number to multiply by 9:");
            
            decimal n = Convert.ToDecimal(Console.ReadLine());
            int n2 = Convert.ToInt32(n);
            string s = n2.ToString();

            Console.WriteLine("Rounded, then multiplied: " + o.MultiplyNine(n2));
            Console.WriteLine("Multiplied, then rounded: " + o.MultiplyNine(n));
            Console.WriteLine("Stringified, multiplied : " + o.MultiplyNine(s));

            Console.ReadLine();


            /*
             *  METHOD SUBMISSION ASSIGNMENT
             */
            OptionalParameter op = new OptionalParameter();

            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer (optional):");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Multiplied together your numbers equal: " + op.MultiplyTogether(num1, num2));
            }
            catch
            {
                Console.WriteLine("Multiplied by 9 your number equals: " + op.MultiplyTogether(num1));
            }

            Console.ReadLine();
        }
    }
}
