using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CorsoDevOps.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            int a = 5;
            int b = 4;
            int expected = 9;

            //Act
           int actual = new Calculator().Add(a, b);

            //Assert
            Assert.AreEqual(expected , actual );
        }
        [TestMethod]
        public void SubTest()
        {
            //Arrange
            int a = 5;
            int b = 4;
            int expected = 1;

            //Act
            int actual = new Calculator().Subtract(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MulTest()
        {
            //Arrange
            int a = 5;
            int b = 4;
            int expected = 20;

            //Act
            int actual = new Calculator().Multiply(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void DivTest()
        {
            //Arrange
            int a = 10;
            int b = 2;
            int expected = 5;

            //Act
            int actual = new Calculator().Divide(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void DivideByZeroTest() 
        {
                //Arrange
                int a = 10;
                int b = 0;
                int expected = 0;
     
                //Act
                int actual = new Calculator().Divide(a, b);

                //Assert

                Assert.AreEqual(expected, actual);

        }
    }
}
