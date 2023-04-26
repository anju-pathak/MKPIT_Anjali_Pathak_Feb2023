using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptation_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2=0;
            int res = 0;
            try
            {
                res = n1 / n2;
                Console.WriteLine("result=" + res);
            }
            catch (Exception  ee) //ee is object of exception class
            {
                Console.WriteLine(ee.ToString());
                   
            }

        }
    }
}
