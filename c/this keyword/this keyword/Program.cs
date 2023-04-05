using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    class order
    {
        public int id;
        string name;

        public void get(int id, string name)
        {
                   this.id = id;
       this.name = name;
        }
        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order ord = new ord();
        }
    }
}
