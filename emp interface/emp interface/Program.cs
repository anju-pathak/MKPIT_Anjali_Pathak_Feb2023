using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 123;
            emp.name = "anjali";
            int n=emp.Id;
            string m=emp.name;
            Console.WriteLine(m);
            Console.WriteLine(n);

            Console.ReadKey();  
        }
        class Employee
        {
            public int Id { get; set; }


            public string name { get; set; }
        }
        


    }
}
