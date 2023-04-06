using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class calculator1t9
    {

        int prevno, num;
        int result = 0;
        char op;

        public char plusclick(int prevno)
        {
            this.prevno = prevno;
            op = '+';
            return op;
        }
        public char minusclick(int prevno)
        {
            this.prevno = prevno;
            op = '-';
            return op;
        }
        public char mulclick(int prevno)
        {
            this.prevno = prevno;
            op = '*';
            return op;

        }

        public char divclick(int prevno)
        {
            this.prevno = prevno;
            op = '/';
            return op;

        }
        public int calcu(int num)
        {
            switch (op)
            {
                case '+':

                    result = prevno + num;
                    break;
                case '-':

                    result = prevno + num;
                    break;

                case '*':

                    result = prevno + num;
                    break;

                case '/':

                    result = prevno + num;
                    break;



            }
            return result;

        }
    }
}