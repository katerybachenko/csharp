using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Main.Classwork.Lesson4
{
    public class CircleArea
    {
        public const double PI = 3.14d;
        public static void CalculateBigger()
        {
            Console.WriteLine("Enter radius1");
            string radius1 = Console.ReadLine();
            Console.WriteLine("Enter radius2");
            string radius2 = Console.ReadLine();
            double radius1Double = Convert.ToDouble(radius1);
            double radius2Double = Convert.ToDouble(radius2);
            Double area1 = PI * radius1Double * radius1Double;
            Double area2 = PI * radius2Double * radius2Double;
            if (area1 > area2)
            {
                Console.WriteLine("Area1 is bigger");
            }
            else
            {
                Console.WriteLine("Area2 is bigger");
            }

        }
    }
}

