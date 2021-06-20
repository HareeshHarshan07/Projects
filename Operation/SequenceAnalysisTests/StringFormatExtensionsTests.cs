using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;

namespace SequenceAnalysisTests
{
    [TestClass]
    public class StringFormatExtensionsTests
    {
        [TestMethod]
        [DataRow("This IS a STRING", "ISSTRING")]
        [DataRow("HOW aRe YOU", "HOWYOU")]
        [DataRow("There IS a M", "ISM")]
        [DataRow(" ", "")]
        public void Verify_GetUpperCaseWordsFromInput_Returns_Correct_Result(string inputString, string expectedResult)
        {
            //Arrange
            var input = inputString;

            //Act
            var actulResult = input.GetUpperCaseWordsFromInput();

            //Assert
            Assert.AreEqual(actulResult, expectedResult);
        }

        [TestMethod]
        [DataRow("HOW ARE U??", "HOWAREU")]
        [DataRow("OnlyStrings1234", "OnlyStrings")]
        [DataRow("There345 IS &*^%a M", "ThereISaM")]
        [DataRow(" ", "")]
        [DataRow("", "")]
        public void Verify_RemoveSpecialCharacters_Returns_Correct_Result(string inputString, string expectedResult)
        {
            //Arrange
            var input = inputString;

            //Act
            var actulResult = input.RemoveNumbersAndSpecialCharacters();

            //Assert
            Assert.AreEqual(actulResult, expectedResult);
        }

        [TestMethod]
        [DataRow("XACDB", "ABCDX")]
        [DataRow("ZBCD", "BCDZ")]
        [DataRow(" ", " ")]
        public void Verify_AsSortedString_Returns_Correct_Result(string inputString, string expectedResult)
        {
            //Arrange
            var input = inputString;

            //Act
            var actulResult = input.AsSortedString();

            //Assert
            Assert.AreEqual(actulResult, expectedResult);
        }
    }
}