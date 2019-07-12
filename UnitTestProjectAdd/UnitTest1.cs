using System;
using Xunit;

namespace CalculatorWithTests.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 20, 10 }, 30)]
        [InlineData(new int[] { 10, 10 }, 20)]
        [InlineData(new int[] { 40, 10 }, 50)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 10, -20 }, -10)]
        [InlineData(new int[] { -100, 0 }, -100)]
        public void Addnums(int[] numbers, int expected)
        {
            //Arrange
            Calculator myCalculator = new Calculator();

            // Act
            int actual = myCalculator.Addnums(numbers);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new int[] { 20, 10 }, 10)]
        [InlineData(new int[] { 10, 10 }, 0)]
        [InlineData(new int[] { 10, 40 }, -30)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 10, -20 }, 30)]
        [InlineData(new int[] { -100, 0 }, -100)]
        public void SubNums(int[] numbers, int expected)
        {

            // Arrange
            Calculator myCalculator = new Calculator();

            // Act
            int actual = myCalculator.Subnums(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 5, 10 }, 50)]
        [InlineData(new int[] { 10, 10 }, 100)]
        [InlineData(new int[] { 10, 40 }, 400)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 2, -20 }, -40)]
        [InlineData(new int[] { -100, 0 }, 0)]
        public void MultiNum(int[] numbers, int expected)
        {

            // Arrange
            Calculator myCalculator = new Calculator();

            // Act
            int actual = myCalculator.MultiNum(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 20, 10 }, 2)]
        [InlineData(new int[] { 10, 10 }, 1)]
        [InlineData(new int[] { 100, 4 }, 25)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 0, -20 }, 0)]
        [InlineData(new int[] { 100, -5 }, 20)]
        public void DividNum(int[] numbers, int expected)
        {

            // Arrange
            Calculator myCalculator = new Calculator();

            // Act
            int actual = myCalculator.DividNum(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4 ,24 }, 4)]
        [InlineData(new int[] { 10, 10 }, 0)]
        [InlineData(new int[] { 10, 40 }, -30)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 10, -20 }, 30)]
        [InlineData(new int[] { -100, 0 }, -100)]
        public void FactNum(int[] numbers, int expected)
        {

            // Arrange
            Calculator myCalculator = new Calculator();

            // Act
            int actual = myCalculator.FactNum(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
