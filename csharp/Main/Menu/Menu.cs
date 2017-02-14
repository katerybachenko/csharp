using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
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
                CircleArea.CalculateBigger();
            }
            else if (a == 2)
            {
                CircleRadius.Calculate();
            }
            else if (a == 3)
            {
                Triangle.TriangleCheck();
            }
            else if (a == 4)
            {
                NumbersCheck.WhichIsBigger();
            }

            else
            {
                Console.WriteLine("Selection is wrong\n\rPress Enter to exit");
                //Environment.Exit(2);

            }
        }
    }
}
