using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymo
{
    internal class current:account
        
    {
        public override int deposite(int amt)
        {
            bal = bal + amt;
            return bal;
        }
    }
}
