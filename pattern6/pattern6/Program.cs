using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=3;i++)
            {
                for(int  j=1; j<=i;j++)
                {
                    for(int k=1; k<=2*i-1;k++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
