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
    }
}
