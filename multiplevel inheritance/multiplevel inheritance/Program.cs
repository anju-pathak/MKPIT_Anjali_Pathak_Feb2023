using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplevel_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Babydog obj = new Babydog();
            obj.sound();
            obj.bark();
            obj.weep();
            Console.ReadKey();
        }
        class Animal
        {
            public void sound()
            {

                Console.WriteLine("sounds...");

            }
        }

        class Dog : Animal
        {
            public void bark()
            {

                Console.WriteLine("barking...");
            }
        }
        class Babydog : Dog
        {
            public void weep()
            {
                Console.WriteLine("weeping....");
            }
        }

    }
}
    

