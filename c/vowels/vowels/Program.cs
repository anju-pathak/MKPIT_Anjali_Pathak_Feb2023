using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter letter");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch=='a' || ch=='e')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("con");
            }
            Console.ReadKey();
        }
    }
}
