using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = string.Format("{0:D}",DateTime.Now);
           
            Console.WriteLine(s1);
        }
    }
}
