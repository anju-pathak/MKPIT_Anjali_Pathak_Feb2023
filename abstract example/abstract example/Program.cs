using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_example
{
    internal class Program
    {
       
        abstract class Animal
        {
            
            public abstract void animalSound();
            
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

       
        class Pig : Animal
        {
            public override void animalSound()
            {
                
                Console.WriteLine("The pig says: wee wee");
            }
        }

          
            static void Main(string[] args)
            {
                Pig myPig = new Pig(); 
                myPig.animalSound(); 
                myPig.sleep(); 
            Console.ReadKey();  
            }
        }
    }

