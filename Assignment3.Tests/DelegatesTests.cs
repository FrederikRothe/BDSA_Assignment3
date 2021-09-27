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
    }
}
