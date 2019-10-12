using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class NewParser
    {
        public List<string> ParseByOne(string str)
        {
            var result = new List<string>();

            var result1 = str.Split('1');
            
            for (int i = 1; i < result1.Length; i++)
                result.Add("1" + result1[i]);

            return result;
        }
    }
}
