using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ushort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort s;
            Console.WriteLine("enter num");
            s = Convert.ToUInt16(Console.ReadLine());   
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
