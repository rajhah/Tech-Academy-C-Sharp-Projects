using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritance
{
    internal class Employee: Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee Name: ");
            base.SayName();
        }
    }
}
