using Exercises.Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseUnitTests.Exercise_1
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [DataRow("test", false)]
        [DataRow("17", false)]
        [DataRow("this a test", false)]
        [DataRow("noon", true)]
        [DataRow("Able was I ere I saw Elba", true)]
        [DataRow("1881", true)]
        [DataRow("repaper", true)]
        [DataTestMethod]
        public void IsPalindrome_GivenParameters_ShouldReturnExpectedResult(string input, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, PalindromesChecker.IsPalindrome(input));
        }
    }
}