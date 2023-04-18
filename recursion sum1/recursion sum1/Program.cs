using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace recursion_sum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = myfun(5, 3);
            Console.WriteLine(res);

        }
        static int myfun(int x, int y)
        {
            if (y <= 0)
                return 1;

            else
            {
                return x + myfun(x, y - 1);
            }
        }
    }
}
