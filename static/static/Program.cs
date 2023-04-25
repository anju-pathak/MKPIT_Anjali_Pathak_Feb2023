using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            acc obj = new acc(123,"manish");
            acc objj = new acc(22, "anjaki");
            obj.display();
            objj.display();
           
        }
        class acc
        {
            public int accno;
            public string name;
            public static float roi = 4.5f;

            public acc(int accno, string name)
            {
                this.accno = accno;
                this.name = name;

            }

            public void display()
            {
                Console.WriteLine("accno" + accno);
                Console.WriteLine("name" + name);
                Console.WriteLine(roi);


            }
        }
    }
}
