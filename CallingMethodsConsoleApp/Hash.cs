using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsConsoleApp
{
    public class Hash
    {
        public int Reverse(int i)
        {
            char[] charArray = i.ToString().ToCharArray();
            Array.Reverse(charArray);
            string back = new string(charArray);
            i = Convert.ToInt32(back);
            return i;
        }

        public int SquareRoot(int i)
        {
            return ((int)Math.Sqrt(i));
        }

        public int Multiply(int i)
        {
            return (i * 2);
        }

    }
}
