using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer obj = new customer();
            obj.id = 111;
            int n = obj.id;
            Console.WriteLine(n);
            Console.ReadLine();
        }
        class customer
        {
            public int id { get; set; }



        }
    }
}
    

