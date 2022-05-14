using System;

namespace Exercises.Exercise_1
{
    public static class StringExtension
    {
        public static string Reverse(this string input)
        {
            var words = input.Split(' ');
            var finalWord = "";
            for (int i = words.Length - 1; i > -1; i--)
            {
                var charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                finalWord += $"{string.Join("", charArray)} ";
            }

            return finalWord.Trim();
        }
    }
}