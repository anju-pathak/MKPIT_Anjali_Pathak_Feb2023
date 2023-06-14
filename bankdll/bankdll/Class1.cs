using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankdll
{
    public class Class1
    {
        int bal = 1000;
        public string deposite(int amount)
        {
            bal = bal + amount;
            return bal.ToString();  
        }
        public string withdraw(int amount)
        {
            bal=bal-amount; 
            return bal.ToString();
        }
    }
}
