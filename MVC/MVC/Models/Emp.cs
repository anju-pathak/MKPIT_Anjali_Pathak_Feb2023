namespace MVC.Models
{
    public class Emp
    {
        public int id, phone_num;
        public string name, address, email;
        public Emp(int a, int b, string c, string d, string e)
        {
            id = a;
            phone_num = b;
            name = c;
            address = d;
            email = e;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public int Phone
        {
            get
            {
                return phone_num;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }
    }
}
 