using System;
using Xunit;
using BDSA2021.Assignment03;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void given_Nested_Array_of_ints_Flatten_Array()
        {   
            //arrange
            var input = new [] {new int[] {1,2,3,4}, new int[] {5,6,7,8}};

            //act
            var output = Extensions.flatten(input);

            //assert
            Assert.Equal(new int[]{1,2,3,4,5,6,7,8}, output);
        }
    }
}
