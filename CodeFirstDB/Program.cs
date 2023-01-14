using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                bool addAnother = false;
                Console.WriteLine("Enter a new student in the database (y/n)?");
                var answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    addAnother = true;
                }
                while (addAnother)
                {
                    Console.WriteLine("Enter student's First Name:");
                    var fName = Console.ReadLine();
                    Console.WriteLine("Enter student's Last Name:");
                    var lName = Console.ReadLine();
                    Console.WriteLine("Enter student's 5-digit id number:");
                    var sId = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        db.Students.Add(new Student
                        {
                            First_name = fName,
                            Last_name = lName,
                            Student_number = sId
                        });
                        db.SaveChanges();


                        
                    }
                    catch
                    {
                        Console.WriteLine("Something went wrong");
                        Console.ReadLine();
                    }

                    Console.WriteLine("Would you like to add another student (y/n)?");
                    answer = Console.ReadLine();
                    if (answer == "yes" || answer == "y")
                    {
                        addAnother= true;
                    }
                    else
                    {
                        addAnother= false;
                    }
                }

                var query = from s in db.Students
                            orderby s.Last_name
                            select s;

                Console.WriteLine("Current students:");
                Console.WriteLine("Last Name".PadRight(30) + "First Name".PadRight(30)+ "Student Id #".PadRight(30));
                foreach (var s in query)
                {
                    Console.Write(s.Last_name.PadRight(30));
                    Console.Write(s.First_name.PadRight(30));
                    Console.Write(s.Student_number.ToString().PadRight(30));
                    Console.Write("\n");
                }
                Console.ReadLine() ;
            }
        }
    }   
}
