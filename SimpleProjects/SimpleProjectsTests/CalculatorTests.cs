using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProjects;

namespace SimpleProjectsTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_GivenTwoNumbers_ShouldReturnCorrectResult()
        {
            // Arrange
            int num1 = 1;
            int num2 = 3;
            int expected = 4;
            Calculator calculator = new Calculator();
            
            // Act
            int actual = calculator.Sum(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
