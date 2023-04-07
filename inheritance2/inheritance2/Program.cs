using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance2
{
    class person
    {
        public int age, mob;
        public string name, add, email;
        public void getdata(int age, int mob, string name, string add, string email)
        {
            this.age = age;
            this.mob = mob;
            this.name = name;

            this.add = add;
        }
        public void display()
        {
            Console.WriteLine(age);
            Console.WriteLine(mob);
            Console.WriteLine(name);
            Console.WriteLine(add);
            Console.WriteLine(email);

        }

    }
    class customer : person
    {
        public int id;

        public void getdata(int id, int age, int mob, string name, string add, string email)
        {
            this.id = id;
            getdata(age, mob, "name", "add", "email");


        }
        public void display()
        {
            base.display();
            Console.WriteLine(id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata(45, 76546, "raju", "nagpur", "anjali@gmail");
            cust.display();
            Console.ReadKey();

        }
    }
}