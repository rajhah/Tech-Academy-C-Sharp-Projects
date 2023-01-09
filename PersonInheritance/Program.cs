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
            
            /*
             * INTERFACE CLASS ASSIGNMENT
             */
            IQuittable quittable = new Employee { FirstName = "Sample", LastName = "Worker", Job = "Generic Job" };
            Console.WriteLine("Job: " + quittable.Job);
            quittable.Quit();
            Console.WriteLine(quittable.Job);
            Console.ReadLine();

            /*
             * OVERLOADING OPERATORS ASSIGNMENT
             */
            Employee idChecker1 = new Employee { Id = 1 };
            Employee idChecker2 = new Employee { Id = 1 };

            // without an overloaded operator method, the employee objects will never match
            if (idChecker1 != idChecker2)
            {
                Console.WriteLine("Employee ids do not match!");
            }
            else if(idChecker1 == idChecker2) 
            {
                Console.WriteLine("Employee ids match!");
            }
            Console.ReadLine() ;
        }
    }
}
