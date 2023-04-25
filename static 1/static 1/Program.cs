using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            details obj = new details(123, "anjali");
            
            details obj1 = new details(3452, "ritu");
            obj.display();
            obj1.display();
        }
        class details
        {
            public int empno;
            public string name;
            public static string cname="greatanjali";

            public details(int empno, string name)
            {
                this.empno = empno;
                this.name = name;
            }
            public void display()
            {
                Console.WriteLine(empno);
                Console.WriteLine(name);
                Console.WriteLine(cname);
            }
        }
    }
}
