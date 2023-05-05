using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        class car
        {
            string name;
            public car(string carname)
            {
                this.name = carname;
            }

            static void Main(string[] args)
            {
                car obj = new car("maruti");
                Console.WriteLine(obj.name);
            }

        }
    }
}   

