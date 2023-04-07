using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance7
{ 
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("eating");
        }

        public class Dog : Animal
        {

            public void bark()
            {
                Console.WriteLine("barking");
            }
        }
        public class Babydog :Dog
        {
            public void weep()
            {
                Console.WriteLine("weeping");
            }
        }
           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Babydog d1 = new Babydog();
            d1.eat();
            d1.bark();
            d1.weep();
        }
    }
}
