using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Parser;

namespace ParserTests
{
    public class NewParserTests
    {
        [Test]
        [TestCase("1111", 4)]
        [TestCase("1234", 1)]
        [TestCase("221214", 2)]
        [TestCase("123123123123", 4)]
        [TestCase("15", 1)]
        public void ParseByOne_FromTestCase_ReturnCountsFromTestCase(string number, int expected)
        {
            var parser = new NewParser();

            var result = parser.ParseByOne(number);

            Assert.AreEqual(expected, result.Count);
        }
    }
}
