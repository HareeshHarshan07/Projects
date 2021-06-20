using System;

namespace SequenceAnalysis
{
    public class StingSequenceAnalysis
    {
        public void GetSortedUpperCaseString()
        {
            Console.WriteLine("Please enter a string :");
            string inputString = Console.ReadLine();

            var result = GetSortedUpperCaseString(inputString);

            if(!result.Equals(string.Empty))
            {
                Console.WriteLine("Sorted upper case string : " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        private string GetSortedUpperCaseString(string inputString)
        {
            return inputString.GetUpperCaseWordsFromInput().RemoveNumbersANdSpecialCharacters().AsSortedString();
        }
    }
}
