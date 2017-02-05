using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Program
    {
       static void Main(string[] args) 
        {
            WideningCasting widening = new WideningCasting();
            widening.conversion();

            NarrowingCasting narrowing = new NarrowingCasting();
            narrowing.Narrowing();

            PrimitiveConvertor primitive = new PrimitiveConvertor();
            primitive.floatToChar();

            PrimitiveConvertor primitive1 = new PrimitiveConvertor();
            primitive1.intToChar();

            PrimitiveConvertor primitive2 = new PrimitiveConvertor();
            primitive2.charToInt();

            Console.ReadLine();

        }

    }
}
