using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recusion__prime_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, prime;
            Console.WriteLine("enter num");
            n1 = Convert.ToInt32(Console.ReadLine());
            prime = checkprime(n1, n1 / 2);
            if (prime == 1)
            {
                Console.WriteLine("prime no");
            }
            else
            {
                Console.WriteLine("not a prime");
            }
            Console.ReadKey();
        }
        
        static int checkprime(int n1, int i)
        {
            if(i==0)
            {
                return 1;
            }
            else
            {
                return checkprime(n1, i-1);
            }
        }
    }
}
