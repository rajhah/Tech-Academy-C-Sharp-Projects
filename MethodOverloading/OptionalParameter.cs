using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class OptionalParameter
    {
        public int MultiplyTogether(int n1, int n2 = 9) { return n1 * n2; }

    }
}
