using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{

    internal class Program
    {
        interface Iaccount
        {
            string deposite(int amt);
        }
        abstract class account : Iaccount
        {
            public int bal= 1500;
            public abstract string deposite(int amt);
            public string showbalance()
            {
            return "bal is" +bal.ToString();
            }
        }
        class saving:account
        {
            int intrest = 500;
            public override string deposite(int amt)
            {
               bal = bal + amt + intrest;
                return "bal with intrest"+bal;
            }
        }
        class current : account
        {
            public override string deposite(int amt)
            {
                bal = bal + amt;
                return "bal without intrest" + bal;
            }
        }

        static void Main(string[] args)
        {
            account act = null;
            string acttype;
            Console.WriteLine("enter account type");
            acttype=Console.ReadLine();
            Console.WriteLine("enter amount");
            int amt=Convert.ToInt32(Console.ReadLine());
            if(acttype=="saving")
            {
                act=new saving();
            }
            else if(acttype=="current")
                {
                act=new current();  

            }
            string res=act.deposite(amt);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalance());
            Console.ReadKey();
        }
    }
}
