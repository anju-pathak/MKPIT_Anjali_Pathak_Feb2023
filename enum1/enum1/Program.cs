using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum1
{
    internal class Program
    {
        enum months
        {
            jan,
            feb,
            march=feb+1,
            april,
            may

        }
        static void Main(string[] args)
        {
            Console.WriteLine("jan is" + Convert.ToInt32(months.jan));
            Console.WriteLine("feb is "+Convert.ToInt32(months.feb));
            Console.WriteLine("march is"+Convert.ToInt32(months.march));
            Console.WriteLine("april is" + Convert.ToInt32(months.april));
            Console.WriteLine("may is" + Convert.ToInt32(months.may));
        }
    }
}
