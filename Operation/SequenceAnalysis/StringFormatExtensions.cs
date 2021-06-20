using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SequenceAnalysis
{
    public static class StringFormatExtensions
    {
        public static string RemoveNumbersANdSpecialCharacters(this string inputString)
        {
            return Regex.Replace(inputString, @"[^a-zA-Z]+", "");
        }

        public static string GetUpperCaseWordsFromInput(this string inputString)
        {
            string upperCaseWord = string.Empty;
            var upperCaseWords = inputString.Split(' ')
                                 .Where(x => String.Equals(x, x.ToUpper(),
                                 StringComparison.Ordinal));
            foreach (var word in upperCaseWords)
            {
                upperCaseWord += word;
            }
            return upperCaseWord;
        }

        public static string AsSortedString(this string inputString)
        {
            return String.Concat(inputString.OrderBy(x => x));
        }

    }
}
