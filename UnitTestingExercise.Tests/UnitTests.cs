using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1000, 2432, 978, 4410)]
        [InlineData(-20, 5, -15, -30)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator challenger = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = challenger.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(8, 9, -1)]
        [InlineData(5, -5, 10)]
        [InlineData(-5, -5, 0)]
        [InlineData(-5, 5, -10)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 100)]
        [InlineData(20, -5, -100)]
        [InlineData(-100, -2, 200)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(10, 0, int.MinValue)]
        [InlineData(10, -5, -2)]
        [InlineData(-6, 2, -3)]
        [InlineData(-30, -2, 15)]


        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator challenger = new Calculator();

            // Act
            int actual;
            try
            {
                actual = challenger.Divide(num1, num2);

                // Assert
                Assert.Equal(expected, actual);
            }
            catch (DivideByZeroException ex)
            {
                // Assert
                Assert.IsType<DivideByZeroException>(ex);
                Assert.Equal("Cannot divide by zero.", ex.Message);


            }
        }
    }
}
