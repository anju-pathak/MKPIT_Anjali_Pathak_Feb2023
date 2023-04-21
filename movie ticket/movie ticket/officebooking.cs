using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_ticket
{
    internal class officebooking:moviena
    {
        private double bookingfees;
        public double Bookingfees { get; set; }

        public float calculateprice(float price)
        {
            int gst = 20;

                return price=gst+price;

        }
    }
}
