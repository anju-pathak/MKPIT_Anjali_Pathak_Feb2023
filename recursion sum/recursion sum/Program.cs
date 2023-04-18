using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace recursion_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, total;
            Console.WriteLine("enter num1");
            Console.WriteLine("enter num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            total = obj.sum(num1, num2);
            total = num1 + num2;
            Console.WriteLine(total);
            Console.ReadKey();
        }
        public int sum(int num1, int num2)
        {
            if (num1 != 0)
                return num1 + num2;

            else
            {
                return 1;
            }

        }
    }
}

