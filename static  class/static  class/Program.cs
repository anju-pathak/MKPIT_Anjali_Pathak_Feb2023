using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static__class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pie=" + calculate.pie);
            Console.WriteLine("cube=" + calculate.cube(3);
        }
        public static class calculate
        {
            public static float pie = 3.14f;
            public static int cube(int n)
            {
            return n* n* n;
            }
        }
    }
}
