using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Assignment1
{
    public class MinMaxTest : IDisposable
    {

        MinMax mmObj;
        String[] args;

        public void Dispose()
        {
            mmObj = new MinMax();
            args = new String[] { };
        }

        [Fact]
        public void ZeroArgsGivenShouldReturnEmptyArr()
        {
            //Arrange
            int[] expected = new int[] { };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
        }

        [Fact]
        public void OneArgGivenShouldReturnEmptyArr()
        {
            //Arrange
            int[] expected = new int[] { };
            args = new String[] { "4" };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneInvalidArgGivenShouldReturnEmptyArr()
        {
            //Arrange
            int[] expected = new int[] { };
            args = new String[] { "U" };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TwoInvalidArgsGivenShouldThrowException()
        {

            //Arrange
            args = new String[] { "U", "I am an invalid arg - hi ho!" };
            //Act
            int[] actual = mmObj.FindMinMax(args);

            //Incomplete, did not find how to test for exceptions.
        }

        [Fact]
        public void TwoEqualNumbersShouldReturnArr()
        {
            //Arrange
            int[] expected = new int[] { 4, 4 };
            args = new String[] { "4", "4" };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoDiffNumbersSmallLargeShouldReturnArr()
        {
            //Arrange
            int[] expected = new int[] { 4, 9 };
            args = new String[] { "4", "9" };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoDiffNumbersLargeSmallShouldReturnArr()
        {
            //Arrange
            int[] expected = new int[] { 9, 14 };
            args = new String[] { "14", "9" };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ManyDiffNumbersShouldReturnArr()
        {
            //Arrange
            int[] expected = new int[] { 1, 456 };
            args = new String[] { "14", "9", "1", "456", "78", "9", "45", "90" };
            //Act
            int[] actual = mmObj.FindMinMax(args);
            //Assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }
    }
}