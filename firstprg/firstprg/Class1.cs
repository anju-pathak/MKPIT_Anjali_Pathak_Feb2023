using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace firstprg
{
    public class Class1
    {

        public string addition(int a, int b)
            {
            int res = a + b;
            return "addition is" + res.ToString();
            }

        public string subtraction(int a, int b)
        {
            int res = a - b;
            return "subtraction is" + res.ToString();
        }


        public string mul(int a, int b)
        {
            int res = a * b;
            return "multiplication is" + res.ToString();
        }


        public string division(int a, int b)
        {
            int res = a / b;
            return "division is" + res.ToString();
        }
    }
}
