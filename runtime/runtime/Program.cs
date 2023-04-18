using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime
{
    internal class Program
    {
          
            class account
        {
            public int bal = 1000;
            public virtual void deposite(int bal)
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
            class current : account
            {
                public override void deposite(int amt)
                {
                   bal=bal + amt;
                    Console.WriteLine("deposite not" + bal);
                }
            }
            static void Main(string[] args)
            {
                int amount;
                Console.WriteLine("enter amount");
                amount=Convert.ToInt32(Console.ReadLine());
                account act = null;
                string acttype;
                Console.WriteLine("enter actype saving or current");
                acttype = Console.ReadLine();
                if(acttype =="saving")
                {
                    act = new saving();
                }
                else if(acttype =="current")
                {
                    act=new current();  
                }
                act.deposite(amount);
                Console.ReadKey();
            }



        }
    }
}


        
    

