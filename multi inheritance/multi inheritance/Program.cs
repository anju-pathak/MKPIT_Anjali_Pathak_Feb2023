using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_inheritance
{
    class person
    {
        public int id;
        public void getper(int id)
        { 
            this.id = id;
        }
        public void displayper()
        {
            Console.WriteLine(id);
        }

    }
    class student:person
    {
        public string name;

        public void getstd(string name)
        { 
            this.name = name;
        }

        public void displaystd()
        {
            
            Console.WriteLine(name);
                
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.getper(56);
            s.displayper();
            s.getstd("anjali");
            s.displaystd();
            Console.ReadKey();

        }
    }
}
