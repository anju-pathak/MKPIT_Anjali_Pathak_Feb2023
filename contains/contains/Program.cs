using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "he";
            string s3 = "hr";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s2.Contains(s3));
        }
    }
}
