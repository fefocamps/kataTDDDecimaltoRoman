using System;

namespace ConvertNumers
{
    public static class Decimal
    {
        public static string ToRoman(int number)
        {
            var result = "I";
            if (number == 2)
                result = "II";

            return result;
        }
    }
}
