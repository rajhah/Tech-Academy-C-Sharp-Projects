using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Overloader
    {
        public int MultiplyNine(int n)
        {
            return (n * 9);
        }

        public int MultiplyNine(decimal n)
        {
            return (int)(n * 9);
        }

        public int MultiplyNine(string s)
        {
            int n = Convert.ToInt32(s);
            return (n * 9);
        }

    }
}
