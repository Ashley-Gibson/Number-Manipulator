using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumberManipulator;
using System.Windows.Forms;

namespace Unit_Testing
{
    [TestClass]
    public class Helper_Tests
    {
        string testInputString = "1,4,5,7,8";
        Label lblError = new Label();

        [TestMethod]
        public void Helper_ConvertStringToList_Test()
        {
            // Arrange
            List<Double> expectedResult = new List<Double>()
            {
                1,4,5,7,8
            };

            // Act
            List<Double> actualResult = Helper.ConvertStringToList(testInputString, ref lblError);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
