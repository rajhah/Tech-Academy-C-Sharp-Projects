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
            
            // If I cast quittable as a new Employee object it will give me access to the attributes inside Employee.
            // However, this feels very janky, and I can't really think of any reason to do this off the top of my head.
            // Seems like, at least in this case, it would make much more sense to just create an Employee object to begin with.
            Employee newQuit = (Employee)quittable;

            // Now I can check the Job of this NEW employee, and remove the Job attribute from the IQuittable interface.
            // I still can't use quittable.Job, this is just a somewhat dubious workaround.
            Console.WriteLine("Job: " + newQuit.Job);

            //For some reason, newQuit.Quit() and quittable.Quit() will both update newQuit.Job now. Why?
            quittable.Quit();
            Console.WriteLine(newQuit.Job);
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
