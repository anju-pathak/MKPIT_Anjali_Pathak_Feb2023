using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endswith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "llo";
            string s3 = "c#";
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s3.EndsWith(s1));
            Console.WriteLine(s3.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
        }
    }
}
