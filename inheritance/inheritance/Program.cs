using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class person
    {
       public int id;
      public  int salary;
    }
    class employee:person 
    { 
        public string name;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.age = 1;
            emp.id =  11;
            emp.name = "Test";
            emp.salary = 100000;
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.salary);
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.age);
            Console.ReadKey();  
        }
    }
}
