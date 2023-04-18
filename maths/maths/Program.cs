using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 3, c = 2;
            int z = a+ b - c /c;
            z = ++a + b + c++;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
