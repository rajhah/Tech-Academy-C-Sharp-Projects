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
            Overloader o = new Overloader();

            Console.WriteLine("Enter a number to multiply by 9:");
            
            decimal n = Convert.ToDecimal(Console.ReadLine());
            int n2 = Convert.ToInt32(n);
            string s = n2.ToString();

            Console.WriteLine("Rounded, then multiplied: " + o.MultiplyNine(n2));
            Console.WriteLine("Multiplied, then rounded: " + o.MultiplyNine(n));
            Console.WriteLine("Stringified, multiplied : " + o.MultiplyNine(s));

            Console.ReadLine();
        }
    }
}
