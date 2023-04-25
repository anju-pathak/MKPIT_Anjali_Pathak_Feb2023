using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            partstd obj = new partstd();
            obj.display();
            obj.displayy();     
            person objj= new person();
            objj.display();
            Console.ReadKey();
        }
        class person
        {
            public virtual void display()
            {
                Console.WriteLine("hello");
            }
        }
        class student : person
        {
            public  sealed override void display() 
            { 
                Console.WriteLine("std");
            }

        }
        class partstd : student
        {
            public  void displayy()
            {
                Console.WriteLine("parttime");
            }
        }
    }
}
