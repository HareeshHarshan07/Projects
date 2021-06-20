using System;

namespace SequenceAnalysis
{
    public class StringSequenceAnalysis
    {
        public void ProcessStringSequence()
        {
            Console.WriteLine("Please enter a string :");
            var inputString = Console.ReadLine();

            var result = GetSortedUpperCaseString(inputString);

            if (!result.Equals(string.Empty))
                Console.WriteLine("Sorted upper case string : " + result);
            else
                Console.WriteLine("Invalid input OR there are no upper case words in the input string.");
        }

        internal string GetSortedUpperCaseString(string inputString)
        {
            return inputString.GetUpperCaseWordsFromInput().RemoveNumbersAndSpecialCharacters().AsSortedString();
        }
    }
}