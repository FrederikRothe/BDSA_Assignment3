using System;
using Xunit;
using Assignment3;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void reverseString_given_Hej_return_jeh()
        {
            //arrange
            var input = "hej";

            //act
            var output = Program.reverseString(input);

            //assert
            Assert.Equal("jeh", output);
        }

        [Fact]
        public void multiplyDecimals_given_0point5_and_0point5_return_0point25()
        {
            //arrange
            var x = 0.5;
            var y = 0.5;

            //act
            var output = Program.multiplyDecimals(x,y);

            //assert
            Assert.Equal(0.25, output);
        }

        [Fact]
        public void numericallyEqually_given_string_0042point3_and_double_42_return_false()
        {
            //arrange
            var inputString = "0042.3";
            var inputDouble = 42.0;

            //act
            var output = Program.numericallyEqually(inputString, inputDouble);

            //assert
            Assert.False(output);
        }
    }
}
