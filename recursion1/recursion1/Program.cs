using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact;
            Console.WriteLine("enter num");
            num=Convert.ToInt32(Console.ReadLine());
            Program obj= new Program();
            fact = obj.factorial(num);
            Console.WriteLine(fact);
            Console.ReadKey();

        }
        public int factorial(int num)
        {
            if(num==0)
            {
                return 1;
            }
            else
            {
                return num * factorial(num - 1);
            }
            
        }
    }
}
