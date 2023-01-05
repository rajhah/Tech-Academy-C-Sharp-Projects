using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonIncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1:");
            Console.WriteLine("Hourly Rate: ");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2:\nHourly Rate: ");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());
            decimal salary1 = (rate1 * hours1) * 52;
            decimal salary2 = (rate2 * hours2) * 52;
            Console.WriteLine("Annual Salary of Person 1: $" + salary1.ToString("N2"));
            Console.WriteLine("Annual Salary of Person 2: $" + salary2.ToString("N2"));
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(salary1 > salary2);
            Console.ReadLine();
        }
    }
}
