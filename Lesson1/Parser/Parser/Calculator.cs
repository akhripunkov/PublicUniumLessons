using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class Calculator
    {
        public int SumDigits(long number)
        {
            var result = 0;

            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
            }
            return result;
        }
    }
}
