using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace CalculationTests
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void TestMethod3()
        {

            //Arrange
            Operation ClassOperation = new Operation();
            int expectedResult = 3;

            //Act
            int result = ClassOperation.Division(27, 9);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}