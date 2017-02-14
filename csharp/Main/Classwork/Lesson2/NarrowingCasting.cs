using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class NarrowingCasting
    {
        int int1 = 127;
        float float1 = 3.123456F;

        public void Narrowing()
        {
            int1 = (short) float1;
            Console.WriteLine(int1);
       
        }
    }
}
