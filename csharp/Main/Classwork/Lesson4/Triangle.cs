using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp.Main.Classwork.Lesson4
{
    public class Triangle
    {
        public static void TriangleCheck()
        {
            Console.WriteLine("input a =");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input b =");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input c =");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Right-angled");
            }
            else
            {
                Console.WriteLine("Not right-angled");
            }
        }

        public bool IsEven(int val)
        {
            if ((int)val / 2 == (double)val / 2)
                return true;
            else
                return false;
        }
    }
}
