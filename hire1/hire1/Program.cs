using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hire1
{
    class person
    {
        public int id;

        public void getdata(int id)
        {
            this.id = id;
        }
        public void display()
        {
            Console.WriteLine(id);
        }
         
    }

    class student : person
    {
        string name;

        public void getstd(string name)
        {
            this.name = "anjali";
        }
        public void displaystd()
        { Console.WriteLine(name); }
    }

    class emp : student
    {
        int sal;


        public void getemp(int sal)
        { this.sal = sal; }
        public void displayemp()
        { Console.WriteLine(sal); } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.getdata(1);
            std.display();
            std.getstd("anjali");
            std.displaystd();
            Console.WriteLine("-------------------------------");
            emp em = new emp();
            em.getdata(1);
            em.display();
            em.getstd("anjali");
            em.displaystd();
            em.getemp(111);
            em.displayemp();
            Console.ReadKey();

        }
    }
}
