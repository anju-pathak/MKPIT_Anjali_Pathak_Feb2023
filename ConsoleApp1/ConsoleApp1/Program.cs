using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class person
    {
      public  int id;
    }
    class std:person
    { 
     public string name;
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            std st = new std();
            st.id = 1;
            st.name = "ravi";
            Console.WriteLine(st.id);
            Console.WriteLine(st.name);
            Console.ReadKey();
        }
    }
}
