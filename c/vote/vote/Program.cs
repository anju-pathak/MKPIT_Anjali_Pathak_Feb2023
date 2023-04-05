using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            Console.Write("please enter age");
            age=Convert.ToInt32(Console.ReadLine());
           if(age>18)
            {
                Console.WriteLine("allow");
            }
           else
            {
                Console.WriteLine("not allow");
                Console.ReadKey();
            }

        }
    }
}
