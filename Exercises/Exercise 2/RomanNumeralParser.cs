using System.Collections.Generic;

namespace Exercises.Exercise_2
{
    public static class RomanNumeralParser
    {
        private static Dictionary<int, string> RomanNumericDictionary;

        static RomanNumeralParser()
        {
            RomanNumericDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
        }

        public static string IntegerToRomanNumeric(int input)
        {
            var returningRomanNumerics = "";

            foreach (var item in RomanNumericDictionary)
            {
                while (input >= item.Key)
                {
                    returningRomanNumerics += item.Value;
                    input -= item.Key;
                }
            }

            return returningRomanNumerics;
        }
    }
}