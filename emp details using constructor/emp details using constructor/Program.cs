using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_details_using_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emp obj = new emp();
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.ReadKey();
        }
        class emp
        {
            public int id;
            public string name;
            public int age;
            public emp()
            {
                Console.WriteLine(id);
                Console.WriteLine("name"+name);
                Console.WriteLine("age"+age);
            }
        }
    }
       
}
