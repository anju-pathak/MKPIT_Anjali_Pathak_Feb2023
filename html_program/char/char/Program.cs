using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char k;
            Console.WriteLine("enter char");
            k=Convert.ToChar(Console.ReadKey());
            Console.WriteLine(k);   
            Console.ReadKey();
        }
    }
}
