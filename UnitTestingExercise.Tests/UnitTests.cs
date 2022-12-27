using System;
using System.Security.Cryptography;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData (5,5,5,15)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange


            // create a Calculator object

            var test = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class

            var actual = test.Add(num1, num2, num3);
            // and store its result in a variable named actual

            //Assert

            Assert.Equal(expected, actual);
            //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,0)]
        [InlineData(5,2,3)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var test = new Calculator();

            //Act

            var actual = test.Subtract(minuend, subtrahend);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 0, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();
            //Act

            var actual = test.Multiply(num1, num2);


            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25,5,5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var test = new Calculator();

            //Act

            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
