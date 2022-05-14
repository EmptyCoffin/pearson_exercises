using Exercises.Exercise_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseUnitTests.Exercise_3
{
    [TestClass]
    public class FibonacciCalculatorTests
    {
        [DataRow(0, 0)]
        [DataRow(-1, 0)]
        [DataRow(1, 0)]
        [DataRow(5, 4)]
        [DataRow(6, 7)]
        [DataRow(7, 12)]
        [DataRow(8, 20)]
        [DataRow(9, 33)]
        [DataTestMethod]
        public void AccumulateFibonacciSeries_GivenN_ShouldReturnSumOfSeriesNumbersBefore(int n, int expectedResult)
        {
            // act
            var result = FibonacciCalculator.AccumulateFibonacciSeries(n);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}