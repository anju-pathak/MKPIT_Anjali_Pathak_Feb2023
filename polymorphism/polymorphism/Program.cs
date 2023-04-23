using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {

        class Animal
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }
        class dog : Animal
        {

            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }


        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            Console.ReadKey();
        }
    }
}

    

