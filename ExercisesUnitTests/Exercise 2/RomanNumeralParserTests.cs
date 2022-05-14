using Exercises.Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseUnitTests.Exercise_2
{
    [TestClass]
    public class RomanNumeralParserTests
    {
        [DataRow(39, "XXXIX")]
        [DataRow(246, "CCXLVI")]
        [DataRow(789, "DCCLXXXIX")]
        [DataRow(2421, "MMCDXXI")]
        [DataRow(999, "CMXCIX")]
        [DataTestMethod]
        public void IntegerToRomanNumeric_ShouldReturnExpectedRomanNumericalValue(int input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, RomanNumeralParser.IntegerToRomanNumeric(input));
        }
    }
}