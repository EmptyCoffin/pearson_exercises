using Exercises.Exercise_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseUnitTests.Exercise_4
{
    [TestClass]
    public class CoinChangeTests
    {
        [DataRow("39p", "1x 20p, 1x 10p, 1x 5p, 2x 2p")]
        [DataRow("101p", "1x 100p, 1x 1p")]
        [DataRow("7p", "1x 5p, 1x 2p")]
        [DataRow("432p", "4x 100p, 1x 20p, 1x 10p, 1x 2p")]
        [DataRow("78p", "1x 50p, 1x 20p, 1x 5p, 1x 2p, 1x 1p")]
        [DataTestMethod]
        public void GetMinimumCoins_GivenInput_ShouldReturnMinimumCoins(string input, string expectedResult)
        {
            // act
            var result = CoinChange.GetMinimumCoins(input);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}