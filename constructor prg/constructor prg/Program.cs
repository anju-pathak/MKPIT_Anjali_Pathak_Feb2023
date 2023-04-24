using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_prg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            detail obj=new detail();
            Console.WriteLine(obj.ToString());
        }
        class detail
        {
            string Name;
             public detail()

            {
                Console.WriteLine(Name);
                Console.ReadLine();
            }
        }
    }
}
