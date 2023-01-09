using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass newClass = new NewClass();
            Console.WriteLine("Enter a whole number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second whole number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            newClass.IntegerOut(n1);

            int oParam;
            OutParams(n1, out oParam, n2);
            Console.WriteLine(n1 + " + " + n2 + " written " + oParam + " times.");
            Console.ReadLine();
            
        }

        // this method has out parmeters
        public static void OutParams(int n, out int nout)
        {
            nout = 0;
            if (n <= 0)
            {
                return;
            }
            else
            {
                int i = 0;
                while (i < n)
                {
                    Console.WriteLine(n);
                    i++; nout++;
                }
            }
        }

        // this is the overloaded version of the above method
        public static void OutParams(int n, out int nout, int n2 = 0)
        {
            nout = 0;
            if (n <= 0)
            {
                return;
            }
            else
            {
                int i = 0;
                while (i < n)
                {
                    Console.WriteLine(n + n2);
                    i++; nout++;
                }
            }
        }
        
        internal static class StaticClass
        {
            //Here is a static class
        }
    }
}
