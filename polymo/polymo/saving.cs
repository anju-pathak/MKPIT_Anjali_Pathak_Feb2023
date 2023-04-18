using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymo
{
    internal class saving:account
    {

        int interest = 500;
        public override int deposite(int amt)
        {
            bal = bal + amt + interest;
            return bal;
        }
    }
        
    }

