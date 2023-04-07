using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance_multilevel
{
    internal class Program
    {
        public class person
        {
            public int id;

            public void getpersondata(int id)
            {
                this.id = id;
            }
            public void displaypersondata()
            {
                Console.WriteLine(id);
            }
        }
        public class student : person
        {
            string name;

            public void getstddata(string name)
            {
                this.name = name;
            }
            public void displaystddata()
            {
                Console.WriteLine(name);
            }
        }
        public class clerk : student
        {
            int sal;

            public void getclerkdata(int sal)
            {
                this.sal = sal;
            }
            public void displayclerkdata()
            {
                Console.Write(sal);
            }
        }
        static void Main(string[] args)
        {
            clerk c = new clerk();
           c.getpersondata(1);

            c.displaypersondata();
            c.getstddata("aja");
            c.displaystddata();
            c.getclerkdata(6554);
            c.displayclerkdata();
            Console.ReadKey();
        }
    }
}
