using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hire
{
    class person
    {
        public int id;
    }
    class student:person
    { 
        public string name;
    }
    class emp:student 
    {
        public int sal;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.id = 1;
            std.name = "test";
            Console.WriteLine(std.id);
            Console.WriteLine(std.name);
            emp emp = new emp();
            emp.id = 1;
            emp.name = "test";
            emp.sal = 874;
            Console.WriteLine(emp.sal);
            Console.WriteLine(emp.name);
                
            Console.WriteLine(emp.id);
            Console.ReadKey();
        }
    }
}
