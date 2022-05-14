using Exercises.Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseUnitTests.Exercise_1
{
    [TestClass]
    public class StringExtensionTests
    {
        [DataRow("Test", "tseT")]
        [DataRow("String Reverse", "esreveR gnirtS")]
        [DataRow("noon", "noon")]
        [DataTestMethod]
        public void Reverse_ShouldReturnReversedString(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, input.Reverse());
        }
    }
}