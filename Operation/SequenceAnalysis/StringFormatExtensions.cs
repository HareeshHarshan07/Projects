using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SequenceAnalysis
{
    public static class StringFormatExtensions
    {
        public static string RemoveNumbersAndSpecialCharacters(this string inputString)
        {
            return Regex.Replace(inputString, @"[^a-zA-Z]+", "");
        }

        public static string GetUpperCaseWordsFromInput(this string inputString)
        {
            var upperCaseWord = string.Empty;
            var upperCaseWords = inputString.Split(' ')
                .Where(x => string.Equals(x, x.ToUpper(),
                    StringComparison.Ordinal));
            foreach (var word in upperCaseWords) upperCaseWord += word;
            return upperCaseWord;
        }

        public static string AsSortedString(this string inputString)
        {
            return string.Concat(inputString.OrderBy(x => x));
        }
    }
}