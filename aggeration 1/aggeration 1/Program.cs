using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggeration_1
{
    enum button:byte
    {
        off,
        on,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 0 or 1 ");
            byte i=Convert.ToByte(Console.ReadLine());
            if(i == (byte)button.off)
            {
                Console.WriteLine("light is off");
            }
            else if(i == (byte)button.on) 
            {
                Console.WriteLine("light is on");
            }
            else { Console.WriteLine("byte cannot hold such value");
            }
        }
    }
}
