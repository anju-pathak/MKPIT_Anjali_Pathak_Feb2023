using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class cal
    {
        int num1,num2;
        int result;
        char op;

        public int calresult(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                     result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                     result = num1 * num2;
                    break;



            }

            return result;
        }
    }
}
