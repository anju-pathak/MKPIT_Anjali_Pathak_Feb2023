using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello c#";
            int index = s1.IndexOf('e');
            Console.WriteLine(index);
        }
    }
}
