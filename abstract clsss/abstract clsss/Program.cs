using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_clsss
{
    internal class Program
    {
        abstract class animal
        {
            public abstract void animalname();

            public void sound()
            {
                Console.WriteLine("fksjf");
            }
        }
        class dog : animal
        {
            public override void animalname()
            { 
            Console.WriteLine("bark");
            }
        }
        static void Main(string[] args)
        {
            dog d = new dog();
            d.animalname();
            d.sound();
        }
    }
}
