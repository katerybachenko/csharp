using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Main.Classwork.Lesson4
{
    public class CircleRadius
    {
        static double radius, pi, circleArea;
        public static void Calculate()
        {
            Console.WriteLine("Bb.radius");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bb.number pi");
            pi = Convert.ToDouble(Console.ReadLine());
            circleArea = pi * radius * radius;
            Console.WriteLine("Area is " + circleArea);
        }
        
    }
}
