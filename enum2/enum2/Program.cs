using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    enum color
    {
        red=1,
            yellow=green+2,
            organe=3,
        green=4,
             blue=5,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("red"+Convert.ToInt32(color.red));
            Console.WriteLine("yellow" + Convert.ToInt32(color.yellow));
            Console.WriteLine("organe"+Convert.ToInt32(color.organe));
            Console.WriteLine("green"+Convert.ToInt32(color.green));
        }
    }
}
