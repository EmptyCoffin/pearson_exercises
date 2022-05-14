using System;

namespace Exercises.Exercise_1
{
    public static class PalindromesChecker
    {
        public static bool IsPalindrome(string input)
        {
            return string.Equals(input, input.Reverse(), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}