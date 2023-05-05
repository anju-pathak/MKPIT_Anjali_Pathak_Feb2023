using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emp obj = new emp();
            {
                obj.showdata();
            }
            Console.ReadKey();
        }
        sealed class emp
        {
            public  void showdata()
            {
                Console.WriteLine("name");
            }
        }
       
        
       

    }
}
