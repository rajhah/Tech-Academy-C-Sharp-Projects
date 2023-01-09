using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class WriteNumbers
    {
        public void Write(int n1, int n2)
        {
            Console.WriteLine((n1 * 9) + " " + n2);
        }
    }
}
