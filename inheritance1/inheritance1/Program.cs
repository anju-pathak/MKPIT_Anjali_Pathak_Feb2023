using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    class person
    {
        public float id=2334;
    }
        class student : person
        {
            public float salary=9883;
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           student s = new student();
            
            Console.WriteLine(s.id);
            Console.WriteLine(s.salary);
            Console.ReadKey();
        }
    }
}
