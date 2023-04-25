using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_user
{
    internal class Program
    {
        class Employee
        {
            public int empno;
            public string empname;
            public static string companyname = "Google";
            public Employee(int empno, string empname)
            {
                this.empno = empno;
                this.empname = empname;
            }

            public void display()
            {
                Console.WriteLine("empno=" + empno);
                Console.WriteLine("empname=" + empname);
                Console.WriteLine("company name=" + companyname);
            }
        }



      
            static void Main(string[] args)
            {
                int empno;
                Console.WriteLine("enter empno");
                empno = Convert.ToInt32(Console.ReadLine());
                string name;
                Console.WriteLine("enter name");
                name = Console.ReadLine();

                int empno1;
                Console.WriteLine("enter empno");
                empno1 = Convert.ToInt32(Console.ReadLine());
                string name1;
                Console.WriteLine("enter name");
                name1 = Console.ReadLine();


                Employee emp = new Employee(empno, name);
                Employee emp1 = new Employee(empno1, name1);
                emp.display();
                emp1.display();
            }
        }
    }


   
