using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp.Main.Homework.Lesson4
{
    public class NumbersCheck
    {
        public static void WhichIsBigger()
        {
            Console.WriteLine("input A = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input B = ");
            double b = Convert.ToDouble(Console.ReadLine());
           
            if (a < b)
            {
                Console.WriteLine("B (" + b + ") is bigger than A (" + a + ")");
            }
            else if (b > a)
            {
                Console.WriteLine("A (" + a + ") is bigger than B (" + b + ")"); 
            }
            else
            {
                Console.WriteLine("A (" + a + ") is equal to B (" + b + ")");
            
            }
        }

      
    }
}
