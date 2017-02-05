using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class PrimitiveConvertor
    {
        int int1 = 122;
        float float1 = 3.123456F;
        char c = (char) 0;

        public void floatToChar()
        {
            float1 = c;
            Console.WriteLine("Input float value is 3.123456F Output char value is {0}", (char)122);
        }
        public void intToChar()
        {
            int1 = c;
            Console.WriteLine("Input int value is 122 Output char value is {0}", (char)122);
        }
        public void charToInt()
        {
            c = (char) int1;
            Console.WriteLine("Input char value is {0} Output int value is 122", (char)122);
        }
    }
}
