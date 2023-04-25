using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                acc obj = new acc(123, "manish");
                acc objj = new acc(22, "anjaki");
                
                obj.display();
                objj.display();
            Console.WriteLine("no of obj" + acc.count);

            }
        class acc
        {
            public int accno;
            public string name;
            public static int count;

            public acc(int accno, string name)
            {
                this.accno = accno;
                this.name = name;
                count++;

            }

            public void display()
            {
                Console.WriteLine("accno" + accno);
                Console.WriteLine("name" + name);
                
            }
        }
    }
}

       