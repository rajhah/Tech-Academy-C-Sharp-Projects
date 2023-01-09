using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritance
{
    internal class Employee: Person, IQuittable
    {
        public int Id { get; set; }
        public string Job { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee Name: ");
            base.SayName();
        }

        public void Quit()
        {
            Job = "None";
        }

        public static bool operator ==(Employee a, Employee b)
        {
            if (a.Id==b.Id)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            if (a.Id != b.Id)
            {
                return true;
            }
            return false;
        }
        
    }
}
