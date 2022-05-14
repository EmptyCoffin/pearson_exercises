using System.Linq;

namespace Exercises.Exercise_3
{
    public static class FibonacciCalculator
    {
        public static int AccumulateFibonacciSeries(int upToNValue) 
        {
            var returningValue = 0;

            if (upToNValue > 1) 
            {
                var fibonacciSeries = GetFibonacci(upToNValue);
                returningValue = fibonacciSeries.SkipLast(1).Sum();
            }

            return returningValue;
        }

        public static int[] GetFibonacci(int numElement)
        {
            int[] a = new int[numElement];
            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i < numElement; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }

            return a;
        }
    }
}