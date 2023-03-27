using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            int res = 0;
            Console.WriteLine("enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator like + - *");
            op=Convert.ToChar(Console.ReadLine());
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num1 - num2;
            else if (op == '*')
                res = num1 * num2;
            else
                Console.WriteLine("invalid");
                Console.ReadKey();
            }
        }
            
    }

