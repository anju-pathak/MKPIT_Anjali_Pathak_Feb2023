using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance6
{
    class person
    {
        public int id;
    }
    class emp:person
    {
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp();
            e.id = 1;
            e.name = "anjali";
            Console.WriteLine(9);
            Console.WriteLine("anjali");
            Console.ReadKey();
        }
    }
}
