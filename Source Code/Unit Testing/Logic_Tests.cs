using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberManipulator;
using System;
using System.Collections.Generic;

namespace Unit_Testing
{
    [TestClass]
    public class Logic_Tests
    {
        Form UnitTestForm = new Form();

        List<Double> testInputList = new List<Double>()
        {
            1, 4, 5, 6, 7
        };

        [TestMethod]
        public void GetMaxValueIndex_Test()
        {
            // Arrange
            int expectedResult = 4;

            // Act
            int actualResult = UnitTestForm.GetMaxValueIndex(testInputList);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetMinValueIndex_Test()
        {
            // Arrange
            int expectedResult = 0;

            // Act
            int actualResult = UnitTestForm.GetMinValueIndex(testInputList);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NormaliseList_Test()
        {
            // Arrange
            List<Double> expectedResult = new List<Double>()
            {
                -1, 0, 1, 2, 3
            };

            // Act
            List<Double> actualResult = UnitTestForm.NormaliseList(testInputList);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InsertionSort_Test()
        {
            // Arrange
            List<Double> expectedResult = new List<Double>()
            {
                1, 4, 5, 6, 7
            };

            // Act
            List<Double> actualResult = UnitTestForm.InsertionSort(testInputList);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
