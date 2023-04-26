using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comapre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = ("hello" );
            string s2 = ("hello1" );
           int res =string.Compare(s1, s2);
            Console.WriteLine(res);
        }
    }
}
