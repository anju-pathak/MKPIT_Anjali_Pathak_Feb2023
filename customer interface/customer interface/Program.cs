using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.Name = "anjali";
            obj.Description = "good";
            string n=obj.Name;
            string m=obj.Description;
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.ReadKey();

        }
        class Customer
        {
            public string Name { get; set; }
            public string Description { get; set; }
            
        }
    }
}
