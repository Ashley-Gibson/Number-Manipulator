using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Testing
{
    [TestClass]
    public class Logic_Tests
    {
        [TestMethod]
        public void GetMaxValueIndex_Test()
        {
            // Arrange
            List<Double> inputList = new List<Double>()
            {
                1, 4, 5, 6, 7
            };

            int expectedResult = 7;

            // Act
            int actualResult = GetMaxValueIndex(inputList);

            // Assert
            Assert.IsEqual(expectedResult, actualResult);
        }
    }
}
