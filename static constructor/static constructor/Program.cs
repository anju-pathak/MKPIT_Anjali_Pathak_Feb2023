using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate a= new calculate();
            calculate b= new calculate();
            a.display();
            b.display();
        }
        public class calculate
        {
            public static float pi;
            static calculate()
            {
                pi = 3.14f;

                Console.WriteLine("rate of interset" + pi);
            }

            public void display()
            {
                Console.WriteLine("rate of interest" + pi);
            }
        }
    }
}
