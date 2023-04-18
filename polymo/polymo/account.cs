using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymo
{
    internal class account
    {
        public int bal=1000;
        public virtual int deposite(int amt)
        {
            return bal;
        }
    }
}