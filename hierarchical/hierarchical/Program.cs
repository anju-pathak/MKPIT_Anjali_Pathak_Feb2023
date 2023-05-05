using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            science obj = new science();
            obj.teach();
            obj.teachscience();
            history obj1 = new history();
            obj1.sst();
            Console.ReadKey();

        }
        class teacher
        {
            public void teach()
            {
                Console.WriteLine("teaches");
            }
        }
        class science : teacher
        {
            public void teachscience() 
            {
                Console.WriteLine("boi....");
            }
        }
        class history:teacher
        {
            public void sst()
            {
                Console.WriteLine("teach sst");
            }
        }

    }
}
