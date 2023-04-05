using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, s, hra, da, t;
            string name;
            Console.WriteLine("enter name");
            name= Console.ReadLine();
            Console.WriteLine("enter no");
            empno= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter s");
            s= Convert.ToInt32(Console.ReadLine());
            hra = (s * 32) / 100;
            da=(s*45) / 100;
            t = s + hra + da;
        }
    }
}
