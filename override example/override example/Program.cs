using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cat cat = new cat();
            dog dog = new dog();
            cat.speak();
            dog.speak();
            Console.ReadKey();  
        }
        class animal
        {
            public virtual void speak()
            {
            Console.WriteLine("animal");
                }

            
        }
        class cat:animal
        { 
            public override void speak()
            {
                Console.WriteLine("meow");
            }
        }
        class dog : animal
        {
            public override void speak()
            {
                Console.WriteLine("bark");
            }
        }
    }
}
