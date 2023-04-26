using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class perimeter
    {
        public enum shape
        {
            circlre, square
        }   
    
    
    public void peri(int val, shape s1)
    {
        if(s1==0)
        {
            float cir = 2 * 3.14f* val;
            Console.WriteLine("circumference of circle is"+cir);
        }
      else
       {
                int perimeter = 4 * val;
         Console.WriteLine("perimeter of sqaure is"+4*val);
        }
     }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            perimeter perimeter = new perimeter();
            perimeter.peri(3, perimeter.shape.circlre);
            perimeter.peri(4, perimeter.shape.square);

        }
    }
}
