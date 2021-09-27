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

        [Fact]
        public void given_An_Array_of_ints_only_return_a_56_63_70()
        {
            //arrange
            var input = new int[] {7,8,42,55,56,63,64,70};

            //act
            var output = Extensions.numbersDivisbleBy7AndGreaterThan42(input);

            //assert

            Assert.Equal(new int[]{56,63,70}, output);
        } 
    }
}
