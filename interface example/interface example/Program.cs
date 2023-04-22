using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cat am = new cat();
            dog an= new dog();  
            am.flee();
            an.hunt();
            Console.ReadKey();
        }

        interface Iprey
        {
            void flee();
        }
        interface Ipredator
        {
            void hunt();
        }

        class cat: Iprey
        {
            public void flee()
            {
            Console.WriteLine("meow");
            }

        }
        class  dog: Ipredator
        {
            public void hunt()
            {
                Console.WriteLine("brak");
            }
        }
    }
}
    
      

