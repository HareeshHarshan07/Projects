using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfMultiple;

namespace SumOfMultipleTests
{
    [TestClass]
    public class ArithmaticOperationExtensionsTests
    {
        [TestMethod]
        [DataRow(6, 8)]
        [DataRow(5, 3)]
        [DataRow(10, 23)]
        [DataRow(16, 60)]
        [DataRow(20, 78)]
        public void Verify_AsSumOfMultipleOfThreeOrFive_Returns_Correct_Result(int inputData, int expectedResult)
        {
            //Arrange
            var input = inputData;

            //Act
            var actulResult = input.AsSumOfMultipleOfThreeOrFive();

            //Assert
            Assert.AreEqual(actulResult, expectedResult);
        }
    }
}