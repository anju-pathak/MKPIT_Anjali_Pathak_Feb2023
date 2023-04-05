using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, r, total;
            string name;
            Console.WriteLine("enter name ");
            name = Console.ReadLine();
            Console.WriteLine("enter p");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter q ");
            r = Convert.ToInt32(Console.ReadLine());
            total = p * r;
            Console.WriteLine("total" + p * r);
            if (total >= 1000)
            {
                total = (18 * total) / 100;
                Console.Write("tax");
            }
            else if (total >= 5000 || total < 10000)
            {
                total= (12 * total) / 100;
                Console.WriteLine("taxx");
            }
            else if(total<5000)
            {
                total=(5*total) / 100;
                Console.WriteLine("texx");
            }
            else
            {
                Console.WriteLine("on tax");
            }
        }
    }
}
