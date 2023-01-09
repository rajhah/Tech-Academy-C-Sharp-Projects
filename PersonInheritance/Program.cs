using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student", Job = "Student" };
            employee.SayName();
            Console.WriteLine("Job: " + employee.Job);
            
            IQuittable quittable = new Employee { FirstName = "Sample", LastName = "Worker", Job = "Generic Job" };
            Console.WriteLine("Job: " + quittable.Job);
            quittable.Quit();
            Console.WriteLine(quittable.Job);
            Console.ReadLine();


        }
    }
}
