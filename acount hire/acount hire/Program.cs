using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acount_hire
{
    class vechicle
    {
        string name;

        public void get(string name)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(name);
        }
    }
     class car:vechicle
    {
        int wheels;

        public void getcar(int wheels) { 
        this.wheels = wheels;
        }

        public void displaycar() { Console.WriteLine(wheels); }

    }

    class truck:vechicle
    {
        int size;

        public void gettruck(int size)
        {
            this.size = size;
        }

        public void displaytruck()
        { Console.WriteLine(size); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            car c= new car();
            c.get("maruti");
            c.display();
            c.getcar(4);
            c.displaycar();

            Console.WriteLine("----------");
            truck t= new truck();   
            t.get("veerna");
            t.display();
           //  t.getcar(4);
            //t.displaycar();
            t.gettruck(678);
            t.displaytruck();
            Console.ReadKey();

        }
    }
}
