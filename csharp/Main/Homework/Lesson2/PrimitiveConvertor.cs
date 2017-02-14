using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Main.Homework.Lesson2
{
    public class PrimitiveConvertor
    {

        float float_input_value = 122.123213F;
        int int_input_value = 120;
        char char_input_value = (char)122;

        public void floatToChar()
        {
            char float_output_value = (char)float_input_value;
            Console.WriteLine("Input float value is " + float_input_value + " Output char value is " + float_output_value);
        }
        public void intToChar()
        {
            char int_output_value = (char)int_input_value;
            Console.WriteLine("Input int value is "+int_input_value+" Output char value is "+ int_output_value);
        }
        public void charToInt()
        {
            int char_output_value = (int) char_input_value;
            Console.WriteLine("Input char value is "+ char_input_value + " Output int value is "+char_output_value);
        }
    }
}
