using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Program
    {

        class account
        {
            public int bal = 1000;
            public  virtual void deposite(int bal)
            {
                Console.WriteLine("deposite");
            }

            class saving : account
            {
                int interest = 500;
                public override void deposite(int amt)
                {
                    bal = bal + amt + interest;
                    Console.WriteLine("deposite bal" + bal);
                }
            }
            static void Main(string[] args)
            {
                account act = new saving();
                act.deposite(200);
                Console.ReadKey();
            }



        }
    }
}

