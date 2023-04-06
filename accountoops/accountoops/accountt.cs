using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace accountoops
{
    internal class accountt
    {
        int acno;
        int bal = 1000;
     

        public int dep( int num)

        {
            
            num = Convert.ToInt32(num);

            bal = bal + num;
            return bal;
        }
        public int width(int num)
        {
            num= Convert.ToInt32(num);
            bal = bal - num;
            return bal;
        }
           
            
                
        }
           
        }
       
    

