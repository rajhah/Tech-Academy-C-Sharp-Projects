using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaJoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees= new List<Employee>();

            // In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            Employee emp1 = new Employee { FirstName = "Joe", LastName = "Burrow", Id = 1 };
            Employee emp2 = new Employee { FirstName = "Joe", LastName = "Schmoe", Id = 2 };
            Employee emp3 = new Employee { FirstName = "Ryan", LastName = "Fitzpatrick", Id = 3 };
            Employee emp4 = new Employee { FirstName = "Rex", LastName = "Ryan", Id = 4 };
            Employee emp5 = new Employee { FirstName = "Sneaky", LastName = "Himbo", Id = 5 };
            Employee emp6 = new Employee { FirstName = "Matt", LastName = "Stafford", Id = 6 };
            Employee emp7 = new Employee { FirstName = "Deshaun", LastName = "Watson", Id = 7 };
            Employee emp8 = new Employee { FirstName = "Joe", LastName = "Green", Id = 8 };
            Employee emp9 = new Employee { FirstName = "Jared", LastName = "Goff", Id = 9 };
            Employee emp10 = new Employee { FirstName = "Aaron", LastName = "Rodgers", Id = 10 };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);
            employees.Add(emp7);
            employees.Add(emp8);
            employees.Add(emp9);
            employees.Add(emp10);

            // Using a foreach loop, create a new list of all employees with the first name “Joe”.
            List<Employee> joes = new List<Employee>();
            foreach (Employee e in employees)
            {
                // In your comparison statement, remember to reference the property of the object you are checking.
                if (e.FirstName == "Joe")
                {
                    joes.Add(e);
                }
            }

            // Perform the same action again, but this time with a lambda expression.
            joes.Clear();
            joes.AddRange(employees.Where(x => x.FirstName == "Joe"));

            foreach (Employee e in joes)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName);
            }

            Console.ReadLine();

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> greaterThanFive = new List<Employee>();
            greaterThanFive.AddRange(employees.Where(x => x.Id > 5));

            foreach (Employee e in greaterThanFive)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName);
            }

            Console.ReadLine();
        }
    }
}
