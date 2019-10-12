using System;
using System.Collections.Generic;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var parser = new NewParser();
            var numbers = parser.ParseByOne(str);

            var output = new OutputNumberAndDigits();
            foreach (var n in numbers)
            {
                output.Output(int.Parse(n));
            }

            Console.ReadKey();
        }
    }
}
