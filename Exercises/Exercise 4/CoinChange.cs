using System;
using System.Collections.Generic;

namespace Exercises.Exercise_4
{
    public static class CoinChange
    {
        private static int[] AvailableCoins = new []{
            100, 50, 20, 10, 5, 2, 1
        };

        public static string GetMinimumCoins(string input)
        {
            var minimumCoins = GenerateMinimumCoins(input);
            var returningString = "";
            foreach (var item in minimumCoins)
            {
                if (item.Value > 0)
                {
                    returningString += $"{item.Value}x {item.Key}p, ";
                }
            }

            return returningString.Substring(0, returningString.Length - 2);
        }

        private static Dictionary<int, int> GenerateMinimumCoins(string input)
        {
            var inputInt = Convert.ToInt32(input.Replace("p", ""));
            var returningCoins = new Dictionary<int, int>();

            foreach (var coin in AvailableCoins)
            {
                while (inputInt >= coin)
                {
                    if (returningCoins.ContainsKey(coin))
                    {
                        returningCoins[coin] = returningCoins[coin] + 1;
                    }
                    else
                    {
                        returningCoins.Add(coin, 1);
                    }
                    inputInt -= coin;
                }
            }

            return returningCoins;
        }
    }
}