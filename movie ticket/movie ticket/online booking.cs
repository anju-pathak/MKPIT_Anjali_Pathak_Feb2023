using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_ticket
{
    internal class online_booking : moviena
    {
        private float discount;

        public float Discount { set; get; }


        public float calculateprice(float price)
        {
            
            return price = price - discount;
        }
    }
}

