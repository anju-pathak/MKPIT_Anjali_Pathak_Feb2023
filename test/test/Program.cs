using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3, x = 1, y = 2;
            int z=((2*x)+(4*y)+9)/ (9 * k) - 2;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
