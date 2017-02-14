using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Main.Menu
{
    public class Menu
    {
        public static void CallMenu()
        {
            Console.WriteLine("Select program by entering number from Menu");
            Console.WriteLine("1.Circle Area");
            Console.WriteLine("2.Circle Radius");
            Console.WriteLine("3.Triangle");
            Console.WriteLine("4.Which Is Bigger");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a == 1)
            {
                Classwork.Lesson4.CircleArea.CalculateBigger();
            }
            else if (a == 2)
            {
                Classwork.Lesson4.CircleRadius.Calculate();
            }
            else if (a == 3)
            {
                Classwork.Lesson4.Triangle.TriangleCheck();
            }
            else if (a == 4)
            {
                Homework.Lesson4.NumbersCheck.WhichIsBigger();
            }

            else
            {
                Console.WriteLine("Selection is wrong\n\rPress Enter to exit");
                //Environment.Exit(2);

            }
        }
    }
}
