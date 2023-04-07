using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    internal class orderrr
    {
        int odno, date, quantity, productrate;
        string name, productname;
        int total = 0;

        public int or(int productrate,int quantity)
        {
            Console.WriteLine("enter productrate");
             productrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity");
            quantity = Convert.ToInt32(Console.ReadLine());
            total= productrate * quantity;

            return total;
        }
    }
}
