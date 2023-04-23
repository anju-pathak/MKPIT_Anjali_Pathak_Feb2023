using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example1
{
    internal class Program
    {
       
          
     interface inter1
        {
            
            void display();
        }

       
        class testClass : inter1
        {

            
            public void display()
            {
                Console.WriteLine("hello");
            }

      
            public static void Main(String[] args)
            {

                
                testClass t = new testClass();

               
                t.display();
                Console.ReadKey();
            }
        }

    }
}

