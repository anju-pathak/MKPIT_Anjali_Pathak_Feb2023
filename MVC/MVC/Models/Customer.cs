namespace MVC.Models
{
    public class Customer
    {
        public int productid, price, quantity;
        public string name;

        public Customer(int a, int b, int c, string d)
        {
            productid = a;
            price = b;
            quantity = c;
            name = d;
        }
        public int PID
        {
            get { return productid; }
        }
         public int Price
        {
            get { return price; }
        }
        public int Qnty
        {
            get { return quantity; }
        }

        public string Name
        { 
            get { return name; }
        }

    }
}
