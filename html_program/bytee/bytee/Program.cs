using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace bytee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1;
            Console.WriteLine("enter b1");
            b1=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter b1" + b1);
            Console.ReadKey();

        }
    }
}
