using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mul_inheristance
{
    class person
    {
        protected int id;
     
    }
    class student:person 
    {
        public int mob;
        public string add;

        public void getdata(int id,int mob,string add)
        {
      this.id = id;
            this.mob = mob;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(mob);
            Console.WriteLine(add);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.getdata(1, 86684660, "nagpur");
            s.display();
            Console.ReadKey();
        }
    
    }
}
