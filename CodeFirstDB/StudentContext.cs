using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB
{
    internal class StudentContext : DbContext
    {
        public DbSet<Student> Students { get;set; }
    }
}
