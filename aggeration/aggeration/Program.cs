using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace aggeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            address a1 = new address("nagpur", "maharashtra");
            employee emp = new employee(324, "mona",a1);
            emp.display();
        }
        class address
        {
            public string city;
            public string state;
            public address(string city, string state)
            {
                this.city = city;   
                this.state = state;
            }
        }
        class employee
        {
            int empno;
            string name;
            address add;
            public employee(int empno, string name,address add)
            { 
                this.empno = empno;
                this.name = name;
                this.add = add;
            }
            public void display()
            {
                Console.WriteLine(empno);
                Console.WriteLine(name);
                Console.WriteLine(add.city);
                Console.WriteLine(add.state);
            }
        }
    }
}
