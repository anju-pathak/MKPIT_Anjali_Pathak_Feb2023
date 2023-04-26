using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "c#";
            Console.WriteLine(string.Concat(s1, s2));
        }
    }
}
