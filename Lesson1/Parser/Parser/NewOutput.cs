using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class OutputNumberAndDigits : IOutput
    {
        public void Output(int number)
        {
            var sum = new Calculator().SumDigits(number);
            Console.WriteLine(number + " Сумма цифр: " + sum);
        }
    }
}
