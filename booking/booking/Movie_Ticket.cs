using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking
{
    abstract internal class Movie_Ticket
    {
        public string Movie_Name { get; set; }
        public string Movie_Theatre { get; set; }
        public int show_time { get; set; }
        public int No_Of_seat { get; set; }

        public int Ticket_price { get; set; }


        public abstract string Calculate_Ticket_Price();
    }
        class Online_booking: Movie_Ticket
        {
        public float Discount { get;set; }
        public override string Calculate_Ticket_Price()
            {
                
           
            float tp = No_Of_seat * Ticket_price + Discount;

            return "Total Price : " + tp.ToString();
        }

        }
    class Box_Office: Movie_Ticket
    {
        public float Amount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_seat * Ticket_price + Amount;    
            return "amount" +tp.ToString();
        }

    }
    }

