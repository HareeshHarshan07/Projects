using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;

namespace SequenceAnalysisTests
{
    [TestClass]
    public class StringSequenceAnalysisTests
    {
        [DataTestMethod]
        [DataRow("HOW ARE U??", "AEHORUW")]
        [DataRow("OnlyStrings1234", "")]
        [DataRow("There345 IS &*^%a M", "IMS")]
        [DataRow(" ", "")]
        [DataRow("", "")]
        public void Verify_GetSortedUpperCaseString_Returns_Correct_Result(string inputString, string expectedResult)
        {
            //Arrange
            var stringSequenceAnalysis = new StringSequenceAnalysis();

            //Act
            var actulResult = stringSequenceAnalysis.GetSortedUpperCaseString(inputString);

            //Assert
            Assert.AreEqual(actulResult, expectedResult);
        }
    }
}