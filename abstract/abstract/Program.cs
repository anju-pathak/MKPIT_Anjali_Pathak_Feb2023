using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
      
                abstract class account
        {
            public int bal = 1000;
            public abstract void deposit(int amt);
            public string showbalance()
            {
                return "bal is" + bal;
            }
        }
        class saving : account
        {
            int intrest = 500;
            public override void deposit(int amt)
            {
                bal = bal + amt + intrest;
                Console.WriteLine("deposite bal is" + bal);
            }
        }

        class current : account
        {
            public override void deposit(int amt)
            {
                bal = bal + amt;
                Console.WriteLine("deposit without intrest bal is" + bal);
            }
        }
        class program
        {
            public static void Main(string[] args)
            {
                int ammount;
                Console.WriteLine("enter ammount");
                ammount = Convert.ToInt32(Console.ReadLine());
                account act = null;
                string acttype;
                Console.WriteLine("enter account type saving or current");
                acttype = Console.ReadLine();
                if (acttype == "saving")
                {
                    act = new saving();
                }


                else if (acttype == "current")
                {
                    act = new current();
                }
                string res = act.showbalance();
                Console.WriteLine(res);

                Console.ReadKey();

            }

        }
    }
}


