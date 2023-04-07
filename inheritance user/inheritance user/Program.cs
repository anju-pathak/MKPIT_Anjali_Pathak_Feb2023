using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_user
{
    class person
    {
        string name;
        string address;
        int mobno;
        string mailid;
        public void getdata(string name, string address, int mobno, string mailid)
        {
            this.name = name;
            this.address = address;
            this.mobno = mobno;
            this.mailid = mailid;
        }
        public void display()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("address" + address);
            Console.WriteLine("mobno" + mobno);
            Console.WriteLine("mailid" + mailid);
        }
    }
    class customer : person
    {
        int custid;
        public void getdata(int custid, string name, string address, int mobno, string mailid)
        {
            this.custid = custid;
            getdata("name", "address", mobno, "mailid");

        }
        public void display()
        {
            base.display();
            Console.WriteLine("custid" + custid);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            customer cust = new customer();
            Console.WriteLine("enter name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter add");
            string address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter mobno ");
            int mobno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mailid");
            string mail = Convert.ToString(Console.ReadLine());
            cust.getdata("name", "address", mobno, "mailid");
            cust.display();
            Console.ReadKey();
        }
    }
}
