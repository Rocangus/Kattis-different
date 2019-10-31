using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kattis_different.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalculateAbsoluteOfDifferenceBetweenInputNumbersTest1()
        {
            //Arrange
            var input = "10 12";
            var expected = 2;
            long actual = 0;

            //Act
            Program.CalculateAbsoluteOfDifferenceBetweenInputNumbers(input, out actual);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void CalculateAbsoluteOfDifferenceBetweenInputNumbersTest2()
        {
            //Arrange
            var input = "71293781758123 72784";
            var expected = 71293781685339;
            long actual = 0;

            //Act
            Program.CalculateAbsoluteOfDifferenceBetweenInputNumbers(input, out actual);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod()]
        public void CalculateAbsoluteOfDifferenceBetweenInputNumbersTest3()
        {
            //Arrange
            var input = "1 12345677654321";
            var expected = 12345677654320;
            long actual = 0;

            //Act
            Program.CalculateAbsoluteOfDifferenceBetweenInputNumbers(input, out actual);

            //Assert
            Assert.AreEqual(actual, expected);
        }

    }
}